using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityIntro.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string SlackHandle { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Animal> Animals { get; set; }
    }
}
