using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Domain.Entities.Identity
{
    public class Role : IdentityRole
    {
        Role() { }
        public Role(string name) : base(name)
        {
            Id = Guid.NewGuid().ToString();
        }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<RoleClaim> RoleClaims { get; set; }
    }
}