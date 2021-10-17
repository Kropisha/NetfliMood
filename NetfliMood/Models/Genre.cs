using System.ComponentModel.DataAnnotations;

namespace NetfliMood.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }

        [StringLength(200, MinimumLength = 3)]
        public string Description { get; set; }
    }
}
