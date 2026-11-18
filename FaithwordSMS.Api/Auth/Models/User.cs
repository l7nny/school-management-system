namespace FaithwordSMS.Api.Auth.Models
{
    public class User
    {



        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public Role Role { get; set; }
        public bool IsActive { get; set; } = true;
        public string PhoneNumber { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

    }
}