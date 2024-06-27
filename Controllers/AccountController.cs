using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Toverland_API.Data;
using Toverland_API.Models;
using Toverland_API_V2.Dtos.Account;
using Toverland_API_V2.Mappers;

namespace Toverland_API_V2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController(ApplicationDBContext context) : ControllerBase
    {
        private readonly ApplicationDBContext _context = context;

        [HttpGet]
        public ActionResult<List<AccountDto>> GetAll() {
            List<AccountDto> accounts;
            try
            {

                accounts = _context.Account
                    .Select(s => s.ToAccountDto())
                    .ToList();
                
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
            return Ok(accounts);
        }

        [HttpGet("{id}")]
        public ActionResult<AccountDto> Get([FromRoute] int id) {
            Account? account = _context.Account.Find(id);

            if (account == null) {
                return NotFound();
            }

            return Ok(account.ToAccountDto());
        }

        [HttpPost]
        public ActionResult<Account> Create([FromBody] Account account)
        {
            if (account == null)
            {
                return BadRequest("Account object is null");
            }

            try
            {
                _context.Account.Add(account);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

            return CreatedAtAction(nameof(Get), new { id = account.Id }, account);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id, [FromBody] Account account)
        {
            if (account == null)
            {
                return BadRequest("Account object is null");
            }

            var existingAccount = _context.Account.Find(id);
            if (existingAccount == null)
            {
                return NotFound();
            }

            // existingAccount.Role = account.Role;
            // existingAccount.UpdatedAt = DateTime.UtcNow;

            try
            {
                _context.Account.Update(existingAccount);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var account = _context.Account.Find(id);
            if (account == null)
            {
                return NotFound();
            }

            // if (account.Role == AccountRole.MANAGER)
            // {
            //     return BadRequest("Cannot delete a manager account");
            // }

            try
            {
                _context.Account.Remove(account);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

            return NoContent();
        }
    }
}