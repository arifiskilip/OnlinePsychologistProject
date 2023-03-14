using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class AppUser : IdentityUser
    {
        public List<Customer> Customers { get; set; }
        public List<Psychologist> Psychologists { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
