using Microsoft.AspNetCore.Identity;

namespace Neon.CRM.WebApp.Data.Models
{
    public class Agent : IdentityUser
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }

        public ICollection<Customer> Customers { get; set; } = [];

    }
}
