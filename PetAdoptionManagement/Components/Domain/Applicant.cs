namespace PetAdoptionManagement.Components.Domain
{
    public class Applicant : BaseDomainModel
    {
        public string Name { get; set; } = string.Empty; 
        public string Email { get; set; } = string.Empty; 
        public int Age { get; set; }
        public string? Address { get; set; } 
        public string PhoneNumber { get; set; } = string.Empty; 
        public ReviewStatusEnum ReviewStatus { get; set; } 
        public int UserId { get; set; } 
        public User? User { get; set; } 
        public ICollection<Application>? Applications { get; set; } 
    }
}
