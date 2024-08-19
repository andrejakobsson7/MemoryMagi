using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemoryMagi.Models
{
    [PrimaryKey("UserId", new string[] { "ItemId" })]

    public class UserItem
    {
        [ForeignKey("User")]
        [Column("user_id")]
        public string UserId { get; set; } = null!;

        public ApplicationUser? User { get; set; }

        [ForeignKey("Item")]
        [Column("item_id")]
        public int ItemId { get; set; }
        public Item? Item { get; set; }

        [Column("is_complete")]
        public bool IsComplete { get; set; }
    }
}
