using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Flight.Dto.Inventory;
using Flight.Entity;
using Flight.Entity.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Flight.Controllers
{
    public class InventoryController : Controller
    {
        private readonly FlightContext _context;
        private readonly IMapper _mapper;

        public InventoryController(FlightContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost("NewInventory")]
        //public async Task<IActionResult> CreateNewInventory(CreateInventory command, CancellationToken cancellationToken)
        //{
        //   var inventory=  _mapper.Map<Inventory>(command);
        //    _context.Add(inventory);
        //    await _context.SaveChangesAsync(cancellationToken);
        //    return Ok();
        //}

    }
}
