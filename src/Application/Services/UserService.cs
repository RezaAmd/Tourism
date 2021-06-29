using Application.Extensions;
using Application.Interfaces;
using Application.Models;
using Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> userManager;
        private readonly IUserClaimsPrincipalFactory<User> userClaimsPrincipalFactory;
        public UserService(UserManager<User> _userManager,
            IUserClaimsPrincipalFactory<User> _userClaimsPrincipalFactory)
        {
            userManager = _userManager;
            userClaimsPrincipalFactory = _userClaimsPrincipalFactory;
        }

        public async Task<string> GetUserNameAsync(string userId)
        {
            var user = await userManager.Users.FirstAsync(u => u.Id == userId);

            return user.UserName;
        }

        public async Task<(Result Result, string UserId)> CreateUserAsync(string userName, string password)
        {
            var user = new User(userName, userName);

            var result = await userManager.CreateAsync(user, password);

            return (result.ToApplicationResult(), user.Id);
        }

        public async Task<bool> IsInRoleAsync(string userId, string role)
        {
            var user = userManager.Users.SingleOrDefault(u => u.Id == userId);

            return await userManager.IsInRoleAsync(user, role);
        }

        public async Task<Result> DeleteUserAsync(string userId)
        {
            var user = userManager.Users.SingleOrDefault(u => u.Id == userId);

            if (user != null)
            {
                return await DeleteUserAsync(user);
            }

            return Result.Success();
        }

        public async Task<Result> DeleteUserAsync(User user)
        {
            var result = await userManager.DeleteAsync(user);

            return result.ToApplicationResult();
        }
    }
}