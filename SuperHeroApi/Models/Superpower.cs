using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperHeroApi.Models
{
    public class Superpower
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The superpower is required")]
        public string SuperPower { get; set; }
        public string Description { get; set; }

        [ForeignKey("SuperheroId")]
        public Guid SuperheroId { get; set; }
        public Superhero Superhero { get; set; }
    }
}
