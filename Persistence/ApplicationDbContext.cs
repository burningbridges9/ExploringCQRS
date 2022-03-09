using Application.Interface;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence.EntityConfiguration;

namespace Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationContext
    {
        public DbSet<Track> Tracks { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TrackConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}