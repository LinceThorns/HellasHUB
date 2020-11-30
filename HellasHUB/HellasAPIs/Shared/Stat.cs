using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellasAPIs.Shared
{
    public class Stat
    {
        [Key]
        public int StatsID { get; set; }
        /// <summary>
        ///Strength, measuring physical power
        /// </summary>
        public string Str { get; set; }
        /// <summary>
        ///Dexterity, measuring agility
        /// </summary>
        public string Dex { get; set; }
        /// <summary>
        ///Constitution, measuring endurance
        /// </summary>
        public string Const { get; set; }
        /// <summary>
        ///Intelligence, measuring reasoning and memory
        /// </summary>
        public string Int { get; set; }
        /// <summary>
        ///Wisdom, measuring Perception and Insight
        /// </summary>
        public string Wis { get; set; }
        /// <summary>
        /// Charisma, measuring force of Personality
        /// </summary>
        public string Cha { get; set; }
    }
}
