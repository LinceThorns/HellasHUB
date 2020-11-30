using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellasAPIs.Shared
{
    public class Money
    {
        [Key]
        public int MoneyID { get; set; }
        /// <summary>
        /// Ammount of money of the character
        /// </summary>
        public int Value { get; set; }
    }
}
