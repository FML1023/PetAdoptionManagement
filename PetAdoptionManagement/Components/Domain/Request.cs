namespace PetAdoptionManagement.Components.Domain
{
    public class Request : BaseDomainModel
    {
        public DateTime DateCreated { get; set; }
        public ReviewStatusEnum ReviewStatus { get; set; }
        public int PetID { get; set; }
        public Pet? Pet { get; set; }
        public int UserID { get; set; }
        public User? User { get; set; }
    }
}
