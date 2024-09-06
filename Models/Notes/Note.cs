using System.ComponentModel.DataAnnotations;
using TasterNotes.Persistence.Models.Dishwares;
using TasterNotes.Persistence.Models.Users;

namespace TasterNotes.Persistence.Models.Notes
{
    public class Note
    {
        public Guid NoteId { get; set; }
        public Guid UserId { get; set; }
        public Guid? DishwareId { get; set; }

        // General info

        [Required]
        [Length(1, 128)]
        public string Title { get; set; } = string.Empty;

        [MaxLength(256)]
        public string Kind { get; set; } = string.Empty;

        [MaxLength(256)]
        public string Region { get; set; } = string.Empty;

        [Range(1900, 2024)]
        public int? Year { get; set; }

        public DateOnly? TastingDate { get; set; }

        // Brewing

        [MaxLength(256)]
        public string BrewingMethod { get; set; } = string.Empty;

        [Range(0, 100)]
        public int BrewingTemperature { get; set; }

        [Range(0, 1_000)]
        public int BrewingVolume { get; set; }

        [Range(0, 100)]
        public int BrewingAmount { get; set; }

        [MaxLength(256)]
        public string BrewingDishware { get; set; } = string.Empty;

        // Dry leaf

        [MaxLength(5_000)]
        public string DryLeafAppearance { get; set; } = string.Empty;

        [MaxLength(5_000)]
        public string DryLeafAroma { get; set; } = string.Empty;

        // Infusion

        [MaxLength(5_000)]
        public string InfusionAppearance { get; set; } = string.Empty;

        [MaxLength(5_000)]
        public string InfusionAroma { get; set; } = string.Empty;

        [MaxLength(5_000)]
        public string InfusionComment { get; set; } = string.Empty;

        [Range(0, 10)]
        public int InfusionBody { get; set; }

        [Range(0, 10)]
        public int InfusionBalance { get; set; }

        [Range(0, 10)]
        public int InfusionBouquet { get; set; }

        [Range(0, 10)]
        public int InfusionExtractivity { get; set; }

        // Aftertaste

        [Range(0, 10)]
        public int AftertasteIntense { get; set; }

        [Range(0, 10)]
        public int AftertasteDuration { get; set; }

        [MaxLength(5_000)]
        public string AftertasteComment { get; set; } = string.Empty;

        // Impression

        [MaxLength(5_000)]
        public string ImpressionComment { get; set; } = string.Empty;

        [Range(0, 10)]
        public int ImpressionRate { get; set; }

        // Other comments

        [MaxLength(5_000)]
        public string WellCombinedWith { get; set; } = string.Empty;

        [MaxLength(5_000)]
        public string OtherComment { get; set; } = string.Empty;

        public User User { get; set; } = null!;
        public DescriptorSet DescriptorSet { get; set; } = null!;
        public Taste Taste { get; set; } = null!;
        public Dishware? Dishware { get; set; }
    }
}
