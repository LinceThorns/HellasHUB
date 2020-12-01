using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int Str { get; set; }
        /// <summary>
        ///Dexterity, measuring agility
        /// </summary>
        public int Dex { get; set; }
        /// <summary>
        ///Constitution, measuring endurance
        /// </summary>
        public int Const { get; set; }
        /// <summary>
        ///Intelligence, measuring reasoning and memory
        /// </summary>
        public int Int { get; set; }
        /// <summary>
        ///Wisdom, measuring Perception and Insight
        /// </summary>
        public int Wis { get; set; }
        /// <summary>
        /// Charisma, measuring force of Personality
        /// </summary>
        public int Cha { get; set; }
    }
}
