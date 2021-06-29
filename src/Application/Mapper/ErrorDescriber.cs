using Microsoft.AspNetCore.Identity;

namespace Application.Mapper
{
    public class ErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError DuplicateUserName(string userName) => new IdentityError { Code = nameof(DuplicateUserName), Description = $"نام کاربری {userName} قبلا توسط شخص دیگری انتخاب شده است." };
        public override IdentityError PasswordTooShort(int length) => new IdentityError { Code = nameof(PasswordTooShort), Description = $"کلمه ی عبور باید حداقل شامل {length} کارکتر باشد." };
        public override IdentityError InvalidUserName(string userName) => new IdentityError { Code = nameof(InvalidUserName), Description = $"نام کاربری باید شامل (0-9) و (a-z) باشد." };
    }
}