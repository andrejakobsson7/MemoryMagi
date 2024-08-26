using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemoryMagi.Models
{
    public class CategoryModel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; } = null!;

        [Column("image_url")]
        public string Image { get; set; } = null!;

        //Navigation properties
        public List<GameModel> Games { get; set; } = new();
    }
}
