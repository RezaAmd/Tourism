﻿using Domain.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IDbContext
    {
        #region Identity
        DbSet<User> Users { get; set; }
        DbSet<Role> Roles { get; set; }
        #endregion

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        #region Custom tables

        #endregion
    }
}