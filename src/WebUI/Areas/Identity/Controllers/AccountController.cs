using Application.Extensions;
using Application.Interfaces;
using Application.Models;
using Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebUI.Areas.Identity.Models;

namespace WebUI.Areas.Identity.Controllers
{
    [Area("Identity")]
    public class AccountController : Controller
    {
        #region Dependency Injection
        private readonly IUserManager userManager;
        private readonly SignInManager<User> signInManager;

        public AccountController(IUserManager _userManager,
            SignInManager<User> _signInManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
        }
        #endregion

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        [ApiModelState]
        public async Task<ApiResult<object>> SignIn([FromBody] SignInViewModel model)
        {
            var user = await userManager.FindByNameAsync(model.username);
            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, model.password, model.isPersistent, true);
                if (result.Succeeded)
                    return Ok();
                if (result.IsLockedOut)
                    return Forbid("این حساب قفل شده است لطفا دقایقی دیگر تلاش کنید.");
            }
            return BadRequest("نام کاربری یا رمز ورود نامعتبر است.");
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [ApiModelState]
        public async Task<ApiResult<object>> SignUp([FromBody] SignUpViewModel model)
        {
            var newUser = new User(model.email, model.email);
            var result = await userManager.CreateAsync(newUser, model.password);
            if (result.Succeeded)
            {
                await signInManager.SignInAsync(newUser, true);
                return Ok("حساب شما با موفقیت ساخته شده است.");
            }
            return BadRequest("درخواست با خطا مواجه شد.");
        }

        [HttpGet]
        public async Task<IActionResult> EmailConfirm(string email, string token)
        {
            ViewData["status"] = 1;

            // 1
            // ایمیل تایید شد

            // 2
            // حساب شما تأیید نشد. لطفا مجددا تلاش فرمایید

            // 3
            // لطفا ایمیل و توکن را ارسال کنید

            return View();
        }

        #region Forgot and reset password
        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [ApiModelState]
        public async Task<ApiResult<object>> ForgotPassword([FromBody] ForgotPasswordIVM model)
        {
            var user = await userManager.FindByIdentityAsync(model.identity);
            if (user != null)
            {

                return Ok();
            }
            return NotFound("هیچ حسابی با این مشخصه یافت نشد.");
        }

        [HttpGet]
        public async Task<IActionResult> ResetPassword(string link)
        {
            return View();
        }

        [HttpPost]
        public async Task<ApiResult<object>> ResetPassword([FromBody] PasswordViewModel model)
        {
            return Ok();
        }
        #endregion
    }
}