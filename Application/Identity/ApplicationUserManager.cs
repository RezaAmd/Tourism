using Application.Common.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;

namespace Application.Identity
{
    public class ApplicationUserManager : UserManager<ApplicationUser>, IApplicationUserManager
    {
        private readonly IApplicationDbContext context;
        private readonly ApplicationIdentityErrorDescriber errors;
        private readonly ILookupNormalizer keyNormalizer;
        private readonly ILogger<ApplicationUserManager> logger;
        private readonly IOptions<IdentityOptions> options;
        private readonly IPasswordHasher<ApplicationUser> passwordHasher;
        private readonly IEnumerable<IPasswordValidator<ApplicationUser>> passwordValidators;
        private readonly IServiceProvider serviceProvider;
        private readonly IUserStore<ApplicationUser> userStore;
        private readonly IEnumerable<IUserValidator<ApplicationUser>> userValidators;

        public ApplicationUserManager(
            IApplicationDbContext _context,
            ApplicationIdentityErrorDescriber _errors,
            ILookupNormalizer _keyNormalizer,
            ILogger<ApplicationUserManager> _logger,
            IOptions<IdentityOptions> _options,
            IPasswordHasher<ApplicationUser> _passwordHasher,
            IEnumerable<IPasswordValidator<ApplicationUser>> _passwordValidators,
            IServiceProvider services,
            IUserStore<ApplicationUser> _userStore,
            IEnumerable<IUserValidator<ApplicationUser>> _userValidators
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

        public string NormalizeKey(string key)
        {

            return key.ToUpper();
        }

    }

}
