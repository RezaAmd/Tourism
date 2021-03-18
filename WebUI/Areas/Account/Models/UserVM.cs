using System.ComponentModel.DataAnnotations;

namespace WebUI.Areas.Account.Models
{
    #region input
    public class SignupViewModel
    {
        [Required(ErrorMessage = "وارد کردن شماره تلفن ضروری است.")]
        [StringLength(11,
            ErrorMessage = "تعداد کارکتر شماره تلفن باید 11 رقم باشد.",
            MinimumLength = 11)]
        [Display(Name = "شماره تلفن")]
        public string phoneNumber { get; set; }

        [MinLength(4, ErrorMessage = "رمز ورود باید حداقل 4 رقم باشد.")]
        [MaxLength(16, ErrorMessage = "رمز ورود باید کمتر از 16 رقم باشد.")]
        [DataType(DataType.Password)]
        [Display(Name = "رمز ورود")]
        public string password { get; set; }

        [Compare("password", ErrorMessage = "رمز ورود و تکرار رمز ورود یکسان نیستند..")]
        [DataType(DataType.Password)]
        [Display(Name = "تکرار رمز ورود")]
        public string passwordConfirm { get; set; }
    }
    public class SigninViewModel
    {
        [StringLength(11,
            ErrorMessage = "تعداد کارکتر شماره تلفن باید 11 رقم باشد.",
            MinimumLength = 11)]
        [Required(ErrorMessage = "وارد کردن شماره تلفن ضروری است.")]
        [Display(Name = "شماره تلفن")]
        public string phoneNumber { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "رمز ورود را وارد کنید.")]
        [MinLength(4, ErrorMessage = "رمز ورود باید حداقل 4 رقم باشد.")]
        [MaxLength(16, ErrorMessage = "رمز ورود باید کمتر از 16 رقم باشد.")]
        [Display(Name = "رمز ورود")]
        public string password { get; set; }
    }
    #endregion

    #region output

    #endregion
}
