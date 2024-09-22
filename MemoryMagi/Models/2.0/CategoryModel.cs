using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemoryMagi.Models
{
    public class CategoryModel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [MinLength(1, ErrorMessage = "Name cannot be empty")]
        [Column("name")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Image is required")]
        [MinLength(1, ErrorMessage = "Image cannot be empty")]
        [Column("image_url")]
        public string Image { get; set; } = null!;

        //Navigation properties
        public List<GameModel> Games { get; set; } = new();
    }
}
