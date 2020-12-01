using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellasAPIs.Shared
{
    /// <summary>
    /// Origin backgrounds available
    /// </summary>
    public class Origin
    {
        [Key]
        public int OriginID { get; set; }
        public string Name { get; set; }
        public int Description { get; set; }

    }
}
