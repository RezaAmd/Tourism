using Application.Extensions;
using Application.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using static WebUI.Areas.Dashboard.Models.ProfileViewModel;

namespace WebUI.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    [Authorize]
    public class ProfileController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ApiResult<object>> Info()
        {
            return Ok();
        }

        [HttpPost]
        [ApiModelState]
        public async Task<ApiResult<object>> Edit([FromBody] EditProfileIVMP model)
        {
            return View();
        }

        [HttpPost]
        [ApiModelState]
        public async Task<ApiResult<object>> ChangePassword([FromBody] ChangePasswordIVM model)
        {
            return Ok();
        }

        [HttpPut]
        [ApiModelState]
        public async Task<ApiResult<object>> AddPhoneNumber([FromBody] AddPhoneNumberIVM model)
        {
            return Ok();
        }

        [HttpGet]
        public async Task<ApiResult<object>> PhoneNumberConfirm(string code)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ApiResult<object>> UploadAvatar([FromForm] IFormFile file)
        {

            return Ok();
        }
    }
}