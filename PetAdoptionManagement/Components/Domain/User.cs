namespace PetAdoptionManagement.Components.Domain
{
    public class User : BaseDomainModel
    {
        public String? Email { get; set; }
        public String? Password { get; set; }
        public String? Name { get; set; }
        public int Age { get; set; }
        public String? Role { get; set; }
        public String? Address { get; set; }
        public String? PhoneNumber { get; set; }
    }
}
