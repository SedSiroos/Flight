using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Flight.Dto.Flight;
using Flight.Dto.Order;
using Flight.Entity;
using Flight.Entity.Domain;
using Flight.Mapping.Persiancalender;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Flight.Controllers
{
    public class FlightController : Controller
    {

        private readonly FlightContext _context;
        private readonly IMapper _mapper;
        public FlightController(FlightContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("NewFlight")]
        public async Task<IActionResult> CreateNewFlight(CreateFlight command, CancellationToken cancellationToken)
        {
            var flight = _mapper.Map<Entity.Domain.Flight>(command);
            _context.Add(flight);
            await _context.SaveChangesAsync(cancellationToken);
            return Ok();
        }

        [HttpGet("flights")]
        public async Task<IActionResult> ListFlight(FlightInputDto command, CancellationToken cancellationToken)
        {

            var miladi = DateTime.Parse(command.FlightDate, new CultureInfo("fa-IR"));


            var flights = _context.Flights
                    .AsNoTracking()
                .Include(x => x.Source).Include(x => x.Destination)
                .Where(x => x.FlightDate.Date == miladi.Date)
                .Where(x => x.Source.Name == command.SourceName)
                .Where(x => x.Destination.Name == command.DestinationName)
                    .ToList()
                ;


            switch (command.SortyBy)
            {
                case "date":
                    flights = flights.OrderBy(x => x.FlightDate).ToList();
                    break;
                case "price":
                    flights = flights.OrderBy(x => x.Price).ToList();
                    break;
                default:
                    flights = flights.OrderByDescending(x => x.Price).ToList();
                    break;
            }

            var returnValue = _mapper.Map<List<FlightOutputDto>>(flights);
            foreach (var flight in returnValue)
            {
                var soldSeatsCount = _context.Inventories.AsNoTracking().Where(x => x.FlightId == flight.FlightId).Sum(x => x.CurrentCount);
                flight.RemainingSeats -= soldSeatsCount;
            }

            
            return Ok(returnValue);
        }


        [HttpPost("Order")]
        public async Task<IActionResult> OrderSuccess(OrderDto command, CancellationToken cancellationToken)
        {
            var message = new MessageResult();

            var order = _mapper.Map<Order>(command);
            _context.Add(order);
            await _context.SaveChangesAsync(cancellationToken);

            _context.Inventories.Add(new Inventory
            {
                CurrentCount =  1,
                FlightId =  command.FlightId,
                OrderId =  order.Id
            });

            await _context.SaveChangesAsync(cancellationToken);
            return Ok(message.Succeeded());
        }
    }
}
