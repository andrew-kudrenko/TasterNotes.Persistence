using System.ComponentModel.DataAnnotations;

namespace TasterNotes.Persistence.Models.Dishwares
{
    public class Dishware
    {
        public Guid DishwareId { get; set; }
        public Guid UserId { get; set; }

        [Length(3, 128)]
        [Required]
        public string Title { get; set; } = string.Empty;

        public string Kind { get; set; } = string.Empty;

        [Range(0, 5_000)]
        public int Volume { get; set; }
    }
}
