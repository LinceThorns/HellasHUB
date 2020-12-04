using HellasAPIs.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HellasAPIs.Server.Models
{
    public class LoggedUserService
    {
        private static Random random = new Random();
        private static string randomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijlkmnopqrstuvxwyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
        }
                
        public Account LoggedAccount { get; set; }
        
        public string GenerateURL()=> randomString(10);
        
    }
}
