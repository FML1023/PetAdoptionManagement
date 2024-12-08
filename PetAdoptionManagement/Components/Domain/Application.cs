namespace PetAdoptionManagement.Components.Domain
{
    public class Application : BaseDomainModel
    {
        public DateTime DateCreated { get; set; }
        public ReviewStatusEnum ReviewStatus { get; set; }
        public String? CreatedBy { get; set; }
        public int PetID { get; set; }
        public int UserID { get; set; }

    }
}
