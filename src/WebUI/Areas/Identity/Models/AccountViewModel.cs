using System.ComponentModel.DataAnnotations;

namespace WebUI.Areas.Identity.Models
{
    #region Input
    public class SignInViewModel
    {
        [Required(ErrorMessage = "نام کاربری را وارد کنید.")]
        public string username { get; set; }
        [Required(ErrorMessage = "رمز ورود را وارد کنید.")]
        public string password { get; set; }
        public bool isPersistent { get; set; }
    }

    public class SignUpViewModel
    {
        public string email { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }
    }

    public class ForgotPasswordIVM
    {
        public string identity { get; set; }
    }

    public class PasswordViewModel
    {
        [Required(ErrorMessage = "رمز ورود را وارد کنید.")]
        public string password { get; set; }

        [Compare("password",ErrorMessage = "رمز ورود و تکرار آن مطابقت ندارند.")]
        public string confirmPassword { get; set; }
    }
    #endregion

    #region Output

    #endregion
}