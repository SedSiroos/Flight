using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Flight.Dto.AirPlanNameDto;
using Flight.Entity;
using Flight.Entity.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Flight.Controllers
{
    public class AirPlaneNameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        private readonly FlightContext _context;
        private readonly IMapper _mapper;

        public AirPlaneNameController(FlightContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //[HttpPost("NewAirPlanName")]
        //public async Task<IActionResult> CreateNewAirPlanName(CreateAirName command, CancellationToken cancellationToken)
        //{
        //    if (_context.Cities.Any(x => x.Name == command.Name))
        //        return BadRequest("نام هواپیما موجود است.");

        //    var airplane = _mapper.Map<Airplane>(command);
        //    _context.Add(airplane);
        //    await _context.SaveChangesAsync(cancellationToken);
        //    return Ok();
        //}


        ////[HttpGet("{id}")]
        //[HttpGet("id")]
        //public async Task<AirPlanNameViewModel> GetAirPlaneName(int id, CancellationToken cancellationToken)
        //{
        //    var airPlaneName = await _context.AirPlanNames.FirstOrDefaultAsync(x => x.Id == id, cancellationToken: cancellationToken);
        //    return _mapper.Map<AirPlanNameViewModel>(airPlaneName);
        //}

        //[HttpGet("ListAirPlaneName")]
        //public async Task<List<AirPlanNameViewModel>> ListCity(AirPlanNameViewModel command, CancellationToken cancellationToken)
        //{
        //    var airPlane = await _context.AirPlanNames.ToListAsync(cancellationToken);
        //    return _mapper.Map<List<AirPlanNameViewModel>>(airPlane);
        //}

        //[HttpPut("id")]
        //public async Task<IActionResult> UpdateAiPlaneName(EditAirName command, CancellationToken cancellationToken)
        //{
        //    var airPlane = await _context.AirPlanNames.FirstOrDefaultAsync(x => x.Id == command.Id, cancellationToken);
        //    _mapper.Map<Airplane>(command);
        //    await _context.SaveChangesAsync(cancellationToken);
        //    return Ok(airPlane);
        //}

        ////حل مشکل async
        //[HttpDelete("delete")]
        //public IActionResult DeleteName(int id)
        //{
        //    var name = _context.AirPlanNames.FirstOrDefault(x => x.Id == id);
        //    _context.Remove(name);
        //    _context.SaveChanges();
        //    return Ok();
        //}
    }
}
