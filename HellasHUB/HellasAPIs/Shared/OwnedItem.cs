using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellasAPIs.Shared
{
    public class OwnedItem
    {
        [Key]
        public int OwnedItemID { get; set; }
        public int Quantity { get; set; }

        public int CharacterId { get; set; }
        [ForeignKey("CharacterId")]
        public Character Character { get; set; }

        public int ItemId { get; set; }
        [ForeignKey("ItemId")]
        public Item Item { get; set; }
    }
}
