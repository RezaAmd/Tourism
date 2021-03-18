using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System;

namespace Domain.Models
{
    public class ApplicationRole : IdentityRole
    {
        ApplicationRole() { }
        public ApplicationRole(string name) : base(name)
        {
            Id = Guid.NewGuid().ToString();
        }
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }

    }
}
