namespace PetAdoptionManagement.Components.Domain
{
    public class Adopter : BaseDomainModel
    {
        public string Name { get; set; } = string.Empty; 
        public string Email { get; set; } = string.Empty;
        public string? LivingSituation { get; set; } 
        public string? OtherPets { get; set; } 
        public string? PetExperience { get; set; } 
        public int Age { get; set; }
        public string? Address { get; set; }
        public ReviewStatusEnum? ReviewStatus { get; set; }
        public int UserId { get; set; } 
        public User? User { get; set; } 
        public ICollection<Request>? Requests { get; set; } 
    }
}
