using System.ComponentModel.DataAnnotations;

namespace TasterNotes.Persistence.Models.Notes
{
    public class DescriptorSet
    {
        [Key]
        public Guid NoteId { get; set; }

        [Range(0, 10)]
        public int Earthy { get; set; }

        [Range(0, 10)]
        public int Animal { get; set; }

        [Range(0, 10)]
        public int Mineral { get; set; }

        [Range(0, 10)]
        public int Sea { get; set; }

        [Range(0, 10)]
        public int Confectionary { get; set; }

        [Range(0, 10)]
        public int Bread { get; set; }

        [Range(0, 10)]
        public int Creamy { get; set; }

        [Range(0, 10)]
        public int Herbaceous { get; set; }

        [Range(0, 10)]
        public int Vegetable { get; set; }

        [Range(0, 10)]
        public int Spicy { get; set; }

        [Range(0, 10)]
        public int Floral { get; set; }

        [Range(0, 10)]
        public int FreshFruity { get; set; }

        [Range(0, 10)]
        public int Citrus { get; set; }

        [Range(0, 10)]
        public int Tropical { get; set; }

        [Range(0, 10)]
        public int Candied { get; set; }

        [Range(0, 10)]
        public int Berry { get; set; }

        [Range(0, 10)]
        public int DriedFrruity { get; set; }

        [Range(0, 10)]
        public int Nutty { get; set; }

        [Range(0, 10)]
        public int Woody { get; set; }

        [Range(0, 10)]
        public int Yeast { get; set; }

        [Range(0, 10)]
        public int Chemical { get; set; }

        [Range(0, 10)]
        public int Mushroom { get; set; }
    }
}
