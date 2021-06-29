using Application.Interfaces;
using Application.Mapper;
using Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Services
{
    public class AppUserManager : UserManager<User>, IUserManager
    {
        #region Dependency Injection
        private readonly IDbContext context;
        private readonly ErrorDescriber errors;
        private readonly ILookupNormalizer keyNormalizer;
        private readonly ILogger<AppUserManager> logger;
        private readonly IOptions<IdentityOptions> options;
        private readonly IPasswordHasher<User> passwordHasher;
        private readonly IEnumerable<IPasswordValidator<User>> passwordValidators;
        private readonly IServiceProvider serviceProvider;
        private readonly IUserStore<User> userStore;
        private readonly IEnumerable<IUserValidator<User>> userValidators;

        public AppUserManager(
            IDbContext _context,
            ErrorDescriber _errors,
            ILookupNormalizer _keyNormalizer,
            ILogger<AppUserManager> _logger,
            IOptions<IdentityOptions> _options,
            IPasswordHasher<User> _passwordHasher,
            IEnumerable<IPasswordValidator<User>> _passwordValidators,
            IServiceProvider services,
            IUserStore<User> _userStore,
            IEnumerable<IUserValidator<User>> _userValidators
            ) : base(_userStore, _options, _passwordHasher, _userValidators, _passwordValidators, _keyNormalizer, _errors, services, _logger)
        {
            errors = _errors;
            keyNormalizer = _keyNormalizer;
            logger = _logger;
            options = _options;
            passwordHasher = _passwordHasher;
            passwordValidators = _passwordValidators;
            serviceProvider = services;
            userStore = _userStore;
            userValidators = _userValidators;
            context = _context;
        }
        #endregion

        public string NormalizeKey(string key)
        {
            return key.ToUpper();
        }

        #region Custom Services
        public async Task<User> FindByIdentityAsync(string identity)
        {
            identity = identity.ToUpper();
            return await context.Users
                .Where(user => user.NormalizedUserName == identity || user.NormalizedEmail == identity
                || user.PhoneNumber == identity).FirstOrDefaultAsync();
        }
        #endregion
    }
}