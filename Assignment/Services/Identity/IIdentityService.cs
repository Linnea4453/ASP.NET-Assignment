﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Identity;

namespace Assignment.Services.Identity
{
    public interface IIdentityService
    {
        Task CreateRootAccountAsync();

        Task CreateNewRole(string roleName);
        Task<IdentityResult> CreateNewUser(AppUser user, string password);

        Task AddUserToRole(AppUser user, string roleName);

        IEnumerable<AppUser> GetAllUsers();

        IEnumerable<IdentityRole> GetAllRoles();

        Task<IEnumerable<UserViewModel>> GetAllUsersWithRolesAsync();

    }
}
