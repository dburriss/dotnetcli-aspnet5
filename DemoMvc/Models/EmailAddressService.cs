using DemoMvc.Abstractions;

namespace DemoMvc.Models
{
    public class EmailAddressService : IEmailAddressService
    {
        public string GetEmail(string department)
        {
            if (department.ToLower() == "support")
                return "support@nuco.com";
            else return "info@nuco.com";
        }
    }
}
