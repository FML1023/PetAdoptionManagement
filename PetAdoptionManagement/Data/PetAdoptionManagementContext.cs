using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetAdoptionManagement.Components.Domain;

namespace PetAdoptionManagement.Data
{
    public class PetAdoptionManagementContext : DbContext
    {
        public PetAdoptionManagementContext (DbContextOptions<PetAdoptionManagementContext> options)
            : base(options)
        {
        }

        public DbSet<PetAdoptionManagement.Components.Domain.Adopter> Adopter { get; set; } = default!;
        public DbSet<PetAdoptionManagement.Components.Domain.Applicant> Applicant { get; set; } = default!;
        public DbSet<PetAdoptionManagement.Components.Domain.Application> Application { get; set; } = default!;
        public DbSet<PetAdoptionManagement.Components.Domain.Pet> Pet { get; set; } = default!;
        public DbSet<PetAdoptionManagement.Components.Domain.Request> Request { get; set; } = default!;
        public DbSet<PetAdoptionManagement.Components.Domain.User> User { get; set; } = default!;
        public DbSet<PetAdoptionManagement.Components.Domain.Spotlight> Spotlight { get; set; } = default!;
    }
}
