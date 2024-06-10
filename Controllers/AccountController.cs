using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Toverland_API.Data;
using Toverland_API.Models;

namespace Toverland_API_V2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController(ApplicationDBContext context) : ControllerBase
    {
        private readonly ApplicationDBContext _context = context;

        [HttpGet]
        public ActionResult<List<Account>> GetAll() {
            List<Account> accounts;
            try
            {
                accounts = _context.Account.ToList();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
            return Ok(accounts);
        }

        [HttpGet("{id}")]
        public ActionResult<Account> Get([FromRoute] int id) {
            Account? account = _context.Account.Find(id);

            if (account == null) {
                return NotFound();
            }

            return Ok(account);
        }
    }
}