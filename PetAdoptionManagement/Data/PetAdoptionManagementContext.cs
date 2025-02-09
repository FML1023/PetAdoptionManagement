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

            // One-to-Many: Pet and User
            builder.Entity<Pet>()
                .HasOne(p => p.User)  // Each Pet is linked to a User
                .WithMany()           // A User can have multiple Pets
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.NoAction); // Prevent multiple cascade paths

            // One-to-Many: A User can have multiple Applications
            builder.Entity<Application>()
                .HasOne(a => a.User)
                .WithMany()
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Cascade);  // When a User is deleted, all their Applications are deleted


            // One-to-One: Pet and Spotlight
            builder.Entity<Spotlight>()
                .HasOne(s => s.Pet)               // Spotlight is linked to one Pet
                .WithOne(p => p.Spotlight)        // Each Pet has one Spotlight
                .HasForeignKey<Spotlight>(s => s.PetId) // Spotlight holds the foreign key
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete when a Pet is deleted

            builder.Entity<Review>(entity =>
            {
                // Set the primary key
                entity.HasKey(r => r.Id);

                // Configure the required relationships
                entity.HasOne(r => r.User)
                      .WithMany() // Assuming a user can have many reviews
                      .HasForeignKey(r => r.UserId)
                      .OnDelete(DeleteBehavior.Cascade); // Delete reviews if the user is deleted

                entity.HasOne(r => r.Pet)
                      .WithMany() // Assuming a pet can have many reviews
                      .HasForeignKey(r => r.PetId)
                      .OnDelete(DeleteBehavior.Cascade); // Delete reviews if the pet is deleted

                // Configure default value for CreatedAt
                entity.Property(r => r.CreatedAt)
                      .HasDefaultValueSql("GETDATE()"); // Use SQL Server's GETDATE function for default
            });
        }
        public DbSet<PetAdoptionManagement.Components.Domain.Review> Review { get; set; } = default!;
    }
}

