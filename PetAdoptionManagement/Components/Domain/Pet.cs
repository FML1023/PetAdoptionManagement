namespace PetAdoptionManagement.Components.Domain
{
    public class Pet : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Species { get; set; }
        public string? Breed { get; set; }
        public int Age { get; set; }
        public string? Description { get; set; }
        public ICollection<string>? Photos { get; set; } 
        public bool Status { get; set; }
        public int SpotlightId { get; set; }
    }
}
