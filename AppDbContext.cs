using Microsoft.EntityFrameworkCore;
using TasterNotes.Persistence.Models.Auth;
using TasterNotes.Persistence.Models.Notes;
using TasterNotes.Persistence.Models.Users;

namespace TasterNotes.Persistence
{
    public class AppDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Note> Notes { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<RefreshSession> RefreshSessions { get; set; } = null!;
    }
}
