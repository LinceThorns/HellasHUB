using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellasAPIs.Shared
{
    /// <summary>
    /// Roles the Character has.
    /// </summary>
    public class OwnedRoles
    {
        [Key]
        public int OwnedRolesID { get; set; }
        public int CharRoleId { get; set; }
        [ForeignKey("CharRoleId")]
        public CharRole CharROle { get; set; }
        public int CharacterId { get; set; }
        [ForeignKey("CharacterId")]
        public Character Character { get; set; }

        //Attributes here
    }
}
