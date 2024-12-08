using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetAdoptionManagement.Data;
using PetAdoptionManagement.Configurations.Entities;
using PetAdoptionManagement.Components.Domain;

namespace PetAdoptionManagement.Data
{
    public class PetAdoptionManagementContext : IdentityDbContext<PetAdoptionManagementUser>
    {
        public PetAdoptionManagementContext(DbContextOptions<PetAdoptionManagementContext> options)
            : base(options)
        {
        }

        public DbSet<Adopter> Adopter { get; set; } = default!;
        public DbSet<Applicant> Applicant { get; set; } = default!;
        public DbSet<Application> Application { get; set; } = default!;
        public DbSet<Pet> Pet { get; set; } = default!;
        public DbSet<Request> Request { get; set; } = default!;
        public DbSet<User> User { get; set; } = default!;
        public DbSet<Spotlight> Spotlight { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Apply configurations for role and user seeding
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
        }
    }
}

