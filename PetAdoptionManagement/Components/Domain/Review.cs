using PetAdoptionManagement.Data;

namespace PetAdoptionManagement.Components.Domain
{
    public class Review : BaseDomainModel
    {
        public string? ReviewText { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UserId { get; set; } = string.Empty;
        public virtual PetAdoptionManagementUser? User { get; set; }
        public int PetId { get; set; }
        public virtual Pet? Pet { get; set; }
    }
}