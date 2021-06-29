using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Domain.Entities.Identity
{
    public class User : IdentityUser
    {
        #region Constructors
        User() { }

        public User(string username)
        {
            UserName = username;
            NormalizedUserName = username.ToUpper();
        }

        public User(string username, string email, bool emailConfirmed = false)
        {
            UserName = username;
            NormalizedUserName = username.ToUpper();

            Email = email;
            NormalizedEmail = email.ToUpper();
            EmailConfirmed = emailConfirmed;
        }

        public User(string username, string email, string phoneNumber, bool emailConfirmed = false, bool phoneNumberConfirmed = false)
        {
            UserName = username;
            NormalizedUserName = username.ToUpper();

            Email = email;
            NormalizedEmail = email.ToUpper();

            PhoneNumber = phoneNumber;
            PhoneNumberConfirmed = phoneNumberConfirmed;
        }
        #endregion

        public string Image { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Bio { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<UserClaim> Claims { get; set; }
        public virtual ICollection<UserLogin> Logins { get; set; }
        public virtual ICollection<UserToken> Tokens { get; set; }
    }
}