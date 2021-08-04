using System.Threading.Tasks;
using AluraChallengeBackend.Core.Data;
using AluraChallengeBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AluraChallengeBackend.Data
{
    public class Context : DbContext, IUnitOfWork
    {
        public DbSet<Video> Videos { get; set; }

        public Context(DbContextOptions<Context> options) : base(options) {}
        
        public async Task<bool> Commit()
        {
            return await SaveChangesAsync() > 0;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);

            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                var properties = entity.GetProperties().Where(p => p.ClrType == typeof(string));
                foreach (var property in properties)
                {
                    if (string.IsNullOrEmpty(property.GetColumnType()) 
                        && !property.GetMaxLength().HasValue) 
                    {
                        property.SetColumnType("VARCHAR(100)");
                    }
                }
            }
        }
    }
}


