using System.ComponentModel.DataAnnotations.Schema;

namespace MemoryMagi.Models
{
    public class UserItem
    {
        [Column("user_id")]
        public int UserId { get; set; }

        [Column("item_id")]
        public int ItemId { get; set; }

        [Column("is_complete")]
        public bool IsComplete { get; set; }
    }
}
