using TasterNotes.Persistence.Models.Users;

namespace TasterNotes.Persistence.Models.Auth
{
    public class RefreshSession
    {
        public Guid RefreshSessionId { get; set; }
        public Guid UserId { get; set; }
        public string Fingerprint { get; set; } = string.Empty;
        public DateTime ExpiresOn { get; set; }
        public DateTime CreatedOn { get; set; }

        public User User { get; set; } = null!;
    }
}
