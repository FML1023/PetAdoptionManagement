using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetAdoptionManagement.Data;

namespace PetAdoptionManagement.Data
{
    public class PetAdoptionManagementContext(DbContextOptions<PetAdoptionManagementContext> options) : IdentityDbContext<PetAdoptionManagementUser>(options)
    {
        public DbSet<PetAdoptionManagement.Components.Domain.Adopter> Adopter { get; set; } = default!;
        public DbSet<PetAdoptionManagement.Components.Domain.Applicant> Applicant { get; set; } = default!;
        public DbSet<PetAdoptionManagement.Components.Domain.Application> Application { get; set; } = default!;
        public DbSet<PetAdoptionManagement.Components.Domain.Pet> Pet { get; set; } = default!;
        public DbSet<PetAdoptionManagement.Components.Domain.Request> Request { get; set; } = default!;
        public DbSet<PetAdoptionManagement.Components.Domain.User> User { get; set; } = default!;
        public DbSet<PetAdoptionManagement.Components.Domain.Spotlight> Spotlight { get; set; } = default!;
    }
}
