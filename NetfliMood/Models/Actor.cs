using System;
using System.ComponentModel.DataAnnotations;

namespace NetfliMood.Models
{
    public class Actor
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string LastName { get; set; }

        [StringLength(20, MinimumLength = 3)]
        public string Country { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
    }
}
