namespace PetAdoptionManagement.Components.Domain
{
    public class Spotlight : BaseDomainModel
    {
        public DateTime StartDate { get; set; }
        public string? Reason { get; set; }
        public bool Status { get; set; }
        public int PetId { get; set; }
        public Pet Pet { get; set; } // A Pet can have exactly one Spotlight
    }
}
