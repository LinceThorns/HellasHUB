using HellasAPIs.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HellasAPIs.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly HellasDbContext _context;
        public AccountController(HellasDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var accounts = await _context.Accounts.ToListAsync();
            return Ok(accounts);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var account = await _context.Accounts.FirstOrDefaultAsync(a => a.UniqueURL== id);
            return Ok(account);
        }
    }
}
