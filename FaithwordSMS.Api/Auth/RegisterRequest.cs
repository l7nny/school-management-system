namespace FaithwordSMS.Api.Auth.Models
{
    public class RegisterRequest
    {
        public required string FullName { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Password { get; set; }
    }
}