using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellasAPIs.Shared
{
    public class Character
    {
        [Key]
        public int CharacterID { get; set; }
        /// <summary>
        /// SL user's UUID
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Money of the character
        /// </summary>
        public int Money { get; set; }

        public int StatId { get; set; }
        [ForeignKey("StatId")]
        public Stat Stat { get; set; }

        public int AccountId { get; set; }
        [ForeignKey("AccountId")]
        public Account Account { get; set; }
        public int OriginId { get; set; }
        [ForeignKey("OriginId")]
        public Origin Origin { get; set; }
    }
}
