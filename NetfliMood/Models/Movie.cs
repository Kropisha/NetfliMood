using System.ComponentModel.DataAnnotations;

namespace NetfliMood.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }

        [StringLength(20, MinimumLength = 3)]
        public string Country { get; set; }

        public int Year { get; set; }

        [StringLength(200, MinimumLength = 3)]
        public string Description { get; set; }

        [Required]
        public int DirectorId { get; set; }
    }
}
