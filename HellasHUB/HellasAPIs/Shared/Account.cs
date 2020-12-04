using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellasAPIs.Shared
{
    public class Account
    {
        [Key]
        public int AccountID { get; set; }
        /// <summary>
        /// UUID Tied to the SL account
        /// </summary>
        public string AccUUID { get; set; }
        /// <summary>
        /// SL's acount name
        /// </summary>
        public string AccName { get; set; }
        public string UniqueURL { get; set; }
    }
}
