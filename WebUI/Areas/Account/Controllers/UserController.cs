using Application.Common.Interfaces;
using Application.Identity;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebUI.Areas.Account.Models;

namespace WebUI.Areas.Account.Controllers
{
    [Area("Account")]
    public class UserController : Controller
    {
        private readonly ApplicationUserManager userManager;
        private readonly SignInManager<ApplicationUser> signinManager;
        public UserController(ApplicationUserManager _userManager,
            SignInManager<ApplicationUser> _signinManager)
        {
            userManager = _userManager;
            signinManager = _signinManager;
        }

        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Signup(SignupViewModel model)
        {
            if (!User.Identity.IsAuthenticated)
            {
                if (ModelState.IsValid)
                {
                    var user = await userManager.FindByNameAsync(model.phoneNumber);
                    if (user == null)
                    {
                        user = new ApplicationUser
                        {
                            UserName = model.phoneNumber,
                            PhoneNumber = model.phoneNumber
                        };
                        var creationResult = await userManager.CreateAsync(user, model.password);
                        if (creationResult.Succeeded)
                        {
                            await signinManager.SignInAsync(user, true);
                        }
                    }
                }
                else
                    return View(model);
            }
            return Redirect("/Home/Index");
        }

        [HttpGet]
        public IActionResult SignIn()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SigninViewModel model)
        {
            if (!User.Identity.IsAuthenticated)
            {
                if (ModelState.IsValid)
                {
                    var user = await userManager.FindByNameAsync(model.phoneNumber);
                    if (user != null)
                    {
                        var passwordValidation = await signinManager.CheckPasswordSignInAsync(user, model.password, false);
                        if (passwordValidation.Succeeded)
                        {
                            await signinManager.SignInAsync(user, false);
                        }
                    }
                }
                else
                    return View(model);
            }
            return Redirect("/Home/Index");
        }
    }
}
