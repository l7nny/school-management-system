namespace FaithwordSMS.Api.Auth.Models
{
    public class User
    {



        public int Id  { get; set;}
        public required string FullName  { get; set;}
        public Role Role { get; set;}
        public bool IsActive { get; set;}
        public string PhoneNumber  { get; set;} = string.Empty;
        public string PasswordHash  { get; set;} = string.Empty;

    }
}