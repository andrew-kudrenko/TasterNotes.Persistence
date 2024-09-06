using TasterNotes.Persistence.Models.Users;

namespace TasterNotes.Persistence.Models.Auth
{
    public class EmailConfirmationCode
    {
        public int EmailConfirmationCodeId { get; set; }
        public int UserId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public bool IsConfirmed { get; set; }
        public DateTime ExpiresOn { get; set; }

        public User User { get; set; } = null!;
    }
}
