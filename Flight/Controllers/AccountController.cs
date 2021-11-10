using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Flight.Dto.Account;
using Flight.Entity;
using Flight.Entity.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Flight.Controllers
{
    public class AccountController : Controller
    {
        private readonly FlightContext _context;
        public AccountController(FlightContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost("NewUser")]
        //public async Task<IActionResult> CreateNewAccount(CreateAccount command, CancellationToken cancellationToken)
        //{
        //    if (_context.Accounts.Any(x => x.FirstName == command.FirstName && x.LastName == command.LastName))
        //        return BadRequest("نام و نام خانوادگی موجود میباشد");

        //    var user = new Account(command.FirstName, command.LastName);
        //    _context.Add(user);
        //    await _context.SaveChangesAsync(cancellationToken);
        //    return Ok();
        //}

        //[HttpGet("GetUserById")]
        //public async Task<IActionResult> GetAccount(int id, CancellationToken cancellationToken)
        //{
        //    var user = await _context.Accounts.FirstOrDefaultAsync(x => x.Id == id,cancellationToken);
        //    return Ok(user);
        //}

        //[HttpPut("EditAccount")]
        //public async Task<IActionResult> UpdateAccount(EditAccount command, CancellationToken cancellationToken)
        //{
        //    var user = await _context.Accounts.FirstOrDefaultAsync(x => x.Id ==command.Id,cancellationToken);
            
        //    user.Edit(command.FirstName,command.LastName);
        //    await _context.SaveChangesAsync(cancellationToken);
        //    return Ok();
        //}
    }
}
