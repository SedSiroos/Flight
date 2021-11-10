using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Flight.Dto.CompanyAirLine;
using Flight.Entity;
using Flight.Entity.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Flight.Controllers
{
    public class CompanyAirLineController : Controller
    {
        private readonly FlightContext _context;
        private readonly IMapper _mapper;

        public CompanyAirLineController(FlightContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost("AddCompany")]
        //public async Task<IActionResult> CreateNewCompany(CreateCompany command,
        //    CancellationToken cancellationToken)
        //{
        //    if (_context.CompanyAirLines.Any(x => x.Name == command.CompanyName))
        //        return BadRequest("نام شرکت هواپیمایی موجود است.");

        //    var company = _mapper.Map<AirLine>(command);
        //    _context.Add(company);
        //    await _context.SaveChangesAsync(cancellationToken);
        //    return Ok();
        //}

        //[HttpGet("GetById")]
        //public async Task<CompanyViewModel> GetCompanyBy(int id, CancellationToken cancellationToken)
        //{
        //    var company = await _context.CompanyAirLines.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        //    return _mapper.Map<CompanyViewModel>(company);
        //}

        //[HttpGet("ListCompanyAirLine")]
        //public async Task<IActionResult> ListCompanyAirLine(CancellationToken cancellationToken)
        //{
        //    var company = await _context.CompanyAirLines.ToListAsync(cancellationToken);
        //    return Ok(company);
        //}

        //[HttpPut("EditCompany")]
        //public async Task<IActionResult> UpdateCompany(EditCompany command, CancellationToken cancellationToken)
        //{
        //    var company =await _context.CompanyAirLines.FirstOrDefaultAsync(x => x.Id == command.Id,cancellationToken);
        //    company.Edit(command.CompanyName,command.Logo);
        //    await _context.SaveChangesAsync(cancellationToken);
        //    return Ok(company);
        //}

        //[HttpGet("List")]
        //public  IActionResult ListCompany()
        //{
        //   var company = _context.CompanyAirLines.ToList();
        //   return Ok(company);
        //}
    }
}
