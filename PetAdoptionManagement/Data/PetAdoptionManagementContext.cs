using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetAdoptionManagement.Data;
using PetAdoptionManagement.Configurations.Entities;
using PetAdoptionManagement.Components.Domain;
using System.Reflection.Emit;

namespace PetAdoptionManagement.Data
{
    public class PetAdoptionManagementContext : IdentityDbContext<PetAdoptionManagementUser>
    {
        public PetAdoptionManagementContext(DbContextOptions<PetAdoptionManagementContext> options)
            : base(options)
        {
        }
        public DbSet<Application> Application { get; set; } = default!;
        public DbSet<Pet> Pet { get; set; } = default!;
        public DbSet<User> User { get; set; } = default!;
        public DbSet<Spotlight> Spotlight { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Apply configurations for role and user seeding
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());

            builder.Entity<Pet>()
        .HasOne(p => p.User)  // Each Pet is linked to a User
        .WithMany()           // A User can have multiple Pets
        .HasForeignKey(p => p.UserId)
        .OnDelete(DeleteBehavior.NoAction);  // ✅ Prevents multiple cascade paths

            builder.Entity<Application>()
    .HasOne(a => a.User)
    .WithMany()
    .HasForeignKey(a => a.UserId)
    .OnDelete(DeleteBehavior.Cascade);
        }


    }
}

