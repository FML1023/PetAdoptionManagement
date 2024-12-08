namespace PetAdoptionManagement.Components.Domain
{
    public abstract class BaseDomainModel
    {
        public int Id { get; set; }
    }

    public enum ReviewStatusEnum
    {
        Pending = 0,
        Approved = 1,
        Rejected = 2
    }

}
