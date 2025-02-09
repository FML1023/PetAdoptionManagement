using PetAdoptionManagement.Data;

namespace PetAdoptionManagement.Components.Domain
{
    public class Pet : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Species { get; set; }
        public string? Breed { get; set; }
        public int Age { get; set; }
        public string? Description { get; set; }
        public bool Status { get; set; }
        public string? PhotoPath { get; set; }
        public string UserId { get; set; } = string.Empty;
        public virtual PetAdoptionManagementUser? User { get; set; }
        public virtual Spotlight? Spotlight { get; set; }
        public ReviewStatusEnum ReviewStatus { get; set; } = ReviewStatusEnum.Pending;
    }
}
