using Microsoft.EntityFrameworkCore;
using sample_mvc.Models;

namespace sample_mvc.Models
{
    public class TeamsContext : DbContext
    {
        public TeamsContext (DbContextOptions<TeamsContext> options)
            : base(options)
        {
        }

        public DbSet<sample_mvc.Models.Teams> Team { get; set; }
    }
}