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
        private readonly LoggedUserService _loggedUser;

        public AccountInfoController(HellasDbContext dbContext , LoggedUserService loggedUser)
        {
            _dbContext = dbContext;
            _loggedUser = loggedUser;
        }
        // GET: api<AccountInfoController>
        [HttpGet]
        public string Get()
        {
            jsonString = "do /(Account Name) at the end.";
            return jsonString;
        }

        // GET api/AccountInfo/5
        [HttpGet("{id}")]
        //https://localhost:44390
        public string Get(string id)
        {
            if(_dbContext.Accounts.Where(x => x.AccUUID == id).Any() == true)
            {
                string urlReturn = "https://localhost:44390/YourArea/" + _dbContext.Accounts.First(x => x.AccUUID == id).UniqueURL;
                return urlReturn;
            }
            else
            {
                string randomURL = _loggedUser.GenerateURL();
                Account account = new Account()
                {
                    AccName = "something",
                    AccUUID = id,
                    UniqueURL=randomURL
                };
                _dbContext.Accounts.Add(account);
                _dbContext.SaveChanges();
                string urlReturn = "https://localhost:44390/YourArea/" + account.UniqueURL;
                return urlReturn;
            }
            
        }
    }
}
