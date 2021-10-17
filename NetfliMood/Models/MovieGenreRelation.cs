using System.ComponentModel.DataAnnotations;

namespace NetfliMood.Models
{
    public class MovieGenreRelation
    {
        public int Id { get; set; }

        [Required]
        public int MovieId { get; set; }

        [Required]
        public int GenreId { get; set; }
    }
}
