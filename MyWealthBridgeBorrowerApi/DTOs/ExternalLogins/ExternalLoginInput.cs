namespace MyWealthBridgeBorrowerApi.DTOs.ExternalLogins
{
    public class ExternalLoginInput
    {
        public string Email { get; set; }
        public string providerId { get; set; }
        public string providerName { get; set; }
        public string Name { get; set; }
    }
}
