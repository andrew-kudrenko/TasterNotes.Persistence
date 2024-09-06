using System.ComponentModel.DataAnnotations;

namespace TasterNotes.Persistence.Models.Notes
{
    public class Taste
    {
        [Key]
        public Guid NoteId { get; set; }

        [Range(0, 10)]
        public int Sweety { get; set; }

        [Range(0, 10)]
        public int Sour { get; set; }

        [Range(0, 10)]
        public int Bitter { get; set; }

        [Range(0, 10)]
        public int Salty { get; set; }

        [Range(0, 10)]
        public int Umami { get; set; }
    }
}
