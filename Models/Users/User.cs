using System.ComponentModel.DataAnnotations;

using TasterNotes.Persistence.Models.Dishwares;
using TasterNotes.Persistence.Models.Notes;

namespace TasterNotes.Persistence.Models.Users
{
    public class User
    {
        public Guid UserId { get; set; }

        [Required]
        [Length(3, 24)]
        public string Nickname { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public bool IsEmailConfirmed { get; set; }

        public string HashedPassword { get; set; } = string.Empty;

        public string? AvatarUrl { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? RemovedOn { get; set; }

        public UserRole Role { get; set; } = UserRole.Ordinary;
        public UserStatus Status { get; set; } = UserStatus.Active;

        public ICollection<Note> Notes { get; set; } = null!;

        public ICollection<Dishware> Dishwares { get; set; } = null!;
    }
}
