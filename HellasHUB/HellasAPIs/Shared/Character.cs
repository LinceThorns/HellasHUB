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
        public string SL_ID { get; set; }
        /// <summary>
        /// SL User Name
        /// </summary>
        public string SL_Name { get; set; }
        /// <summary>
        /// Name of the roleplaying Character
        /// </summary>
        public string IC_Name { get; set; }
        /// <summary>
        /// Money of the character
        /// </summary>
        public int MoneyId { get; set; }
        [ForeignKey("MoneyId")]
        public Money Money { get; set; }

        public int StatId { get; set; }
        [ForeignKey("StatId")]
        public Stat Stat { get; set; }
    }
}
