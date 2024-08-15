using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemoryMagi.Models
{
    public class User
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("username")]
        public string Username { get; set; } = null!;

        [Column("password")]
        public string Password { get; set; } = null!;

        [Column("level")]
        public int Level { get; set; }

        //Navigation property
        public List<Category> Categories { get; set; } = new();
    }
}
