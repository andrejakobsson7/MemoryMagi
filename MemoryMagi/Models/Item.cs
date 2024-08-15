using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemoryMagi.Models
{
    public class Item
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; } = null!;

        [Column("image")]
        public string Image { get; set; } = null!;

        [Column("category_id")]
        public int CategoryId { get; set; }
    }
}
