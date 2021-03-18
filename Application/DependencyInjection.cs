using Application.Common.Interfaces;
using Application.Identity;
using Microsoft.AspNetCore.Identity;
using Domain.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {

            return services;
        }
    }
}
