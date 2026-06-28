using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto.Paddings;
using TodoApp.Models.Entities;

namespace TodoApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TaskItem> TaskItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder); 

            builder.Entity<TaskItem>(entity =>
            {
                entity.HasIndex(t => t.UserId); 
                entity.HasIndex(t => t.IsCompleted); 
                entity.HasIndex(t => t.DueDate); 
            });
        }
    }
}