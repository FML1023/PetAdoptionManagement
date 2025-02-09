using PetAdoptionManagement.Data;

namespace PetAdoptionManagement.Components.Domain
{
    public class Application : BaseDomainModel
    {
        public DateTime DateCreated { get; set; }
        public ReviewStatusEnum ReviewStatus { get; set; } = ReviewStatusEnum.Pending;
        public string? CreatedBy { get; set; } = string.Empty;
        public int PetID { get; set; }
        public string UserId { get; set; } = string.Empty;
        public string ReasonForAdoption { get; set; } = string.Empty;
        public string LivingSituation { get; set; } = string.Empty;
        public string OtherPets { get; set; } = string.Empty;
        public string PetExperience { get; set; } = string.Empty;

        public virtual PetAdoptionManagementUser? User { get; set; }
        public virtual Pet? Pet { get; set; }
    }
}
