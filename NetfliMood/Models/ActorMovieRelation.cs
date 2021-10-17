using System.ComponentModel.DataAnnotations;

namespace NetfliMood.Models
{
    public class ActorMovieRelation
    {
        public int Id { get; set; }

        [Required]
        public int ActorId { get; set; }

        [Required]
        public int MovieId { get; set; }
    }
}
