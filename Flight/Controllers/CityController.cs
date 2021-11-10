
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Flight.Dto.City;
using Flight.Entity;
using Flight.Entity.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Flight.Controllers
{
    public class CityController : Controller
    {
        private readonly FlightContext _context;
        private readonly IMapper _mapper;

        public CityController(FlightContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //[HttpPost("AddCity")]
        //public async Task<IActionResult> CreateNewCity(CreateCity command, CancellationToken cancellationToken)
        //{
        //    if (await _context.Cities.AnyAsync(x => x.Name == command.CityName,cancellationToken))
        //        return BadRequest("نام شهر موجود است.");

        //    var city = _mapper.Map<City>(command);
        //    _context.Add(city);
        //    await _context.SaveChangesAsync(cancellationToken);
        //    return Ok();
        //}

        //[HttpGet("{id}")]
        //public async Task<CityViewModel> GetCity(int id, CancellationToken cancellationToken)
        //{
        //    var city = await _context.Cities.FirstOrDefaultAsync(x => x.Id == id, cancellationToken: cancellationToken);
        //    return _mapper.Map<CityViewModel>(city);
        //}

        //[HttpGet("ListCity")]
        //public async Task<List<CityViewModel>> ListCity(CityViewModel command, CancellationToken cancellationToken)
        //{
        //    var city = await _context.Cities.ToListAsync(cancellationToken);
        //    return _mapper.Map<List<CityViewModel>>(city);
        //}

        //[HttpPut("{id}")]
        //public async Task<IActionResult> EditCity(EditCity command, CancellationToken cancellationToken)
        //{
        //    var city = _context.Cities.SingleOrDefaultAsync(x => x.Id == command.Id, cancellationToken);
        //    if (city == null)
        //        return BadRequest("اشتباه است.");
            
        //    _mapper.Map<City>(city);
        //    await _context.SaveChangesAsync(cancellationToken);
        //    return Ok(city);
        //}

        //[HttpDelete("DeleteCity")]
        //public async Task<IActionResult> DeleteCity(int id)
        //{
        //    var city = _context.Cities.Where(x => x.Id == id);

        //    _context.Remove(city);
        //    await _context.SaveChangesAsync();
        //    return Ok();
        //}
    }
}
