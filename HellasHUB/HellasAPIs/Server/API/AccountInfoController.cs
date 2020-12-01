using HellasAPIs.Server.Models;
using HellasAPIs.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HellasAPIs.Server.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountInfoController : ControllerBase
    {
        private Character character1;
        private string jsonString;
        private readonly HellasDbContext _dbContext;
        public AccountInfoController(HellasDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: api<AccountInfoController>
        [HttpGet]
        public string Get()
        {
            jsonString = JsonSerializer.Serialize(character1);
            return jsonString;
        }

        // GET api/AccountInfo/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            if(_dbContext.Accounts.Where(x => x.AccUUID == id).Any() == true)
            {
                return "Welcome back" + id;
            }
            else
            {
                Account account = new Account()
                {
                    AccName = "something",
                    AccUUID = id
                };
                _dbContext.Accounts.Add(account);
                _dbContext.SaveChanges();
                return "Welcome to Hellas, " + id;
            }
            
        }
    }
}
