using Lucene.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lucene.Api
{
    public class LuceneDbContext : DbContext
    {
        public DbSet<SyncDataControl> SyncDataControls { get; set; }

        public LuceneDbContext(DbContextOptions<LuceneDbContext> options) : base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
