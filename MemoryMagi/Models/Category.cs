using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemoryMagi.Models
{
    public class Category
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; } = null!;

        [Column("user_id")]
        public string? UserId { get; set; }

        //Navigation properties
        public ApplicationUser? User { get; set; }
        public List<Item> Items { get; set; } = new();
    }
}
