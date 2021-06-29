using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.Dashboard.Models
{
    public class ProfileViewModel
    {
        #region Input
        public class EditProfileIVMP
        {
            [Required(ErrorMessage = "نام خود را وارد کنید.")]
            public string name { get; set; }
            [Required(ErrorMessage = "نام خانوادگی خود را وارد کنید.")]
            public string surname { get; set; }
            public string bio { get; set; }
        }

        public class ChangePasswordIVM
        {
            [Required(ErrorMessage = "رمز خود را وارد کنید.")]
            public string password { get; set; }

            [Required(ErrorMessage = "رمز جدید خود را وارد کنید.")]
            public string newPassword { get; set; }

            [Compare("newPassword", ErrorMessage = "رمز ورود با تکرار آن مطابقت ندارد.")]
            public string confirmNewPassword { get; set; }
        }

        public class AddPhoneNumberIVM
        {
            [Required(ErrorMessage = "شماره همراه را وارد کنید.")]
            public string phoneNumber { get; set; }
        }
        #endregion

        #region Output

        #endregion
    }
}
