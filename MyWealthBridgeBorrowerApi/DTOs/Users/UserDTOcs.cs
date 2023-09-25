namespace MyWealthBridgeBorrowerApi.DTOs.Users
{
    public class UserDTOcs
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Phone { get; set; }
        public UserDTOcs() { }
        public UserDTOcs( string? name, string? email, string? password, string? phone)
        {
            Name = name;
            Email = email;
            Password = password;
            Phone = phone;
        }
    }
}
