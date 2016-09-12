﻿using Microsoft.AspNet.Identity.EntityFramework;

namespace EoraMarketplace.Data.Domain.Users
{
    /// <summary>
    ///     User entity for Asp.NET identity
    /// </summary>
    public class User : IdentityUser<int, UserLogins, UserRoles, UserClaims>
    {
    }
}
