using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellasAPIs.Shared
{
    /// <summary>
    /// Roles Available in Hellas
    /// </summary>
    public class CharRole
    {
        [Key]
        public int CharRoleID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Attributes here
    }
}
