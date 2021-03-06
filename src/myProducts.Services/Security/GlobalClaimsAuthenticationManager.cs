﻿using System.Security.Claims;

namespace MyProducts.Services.Security
{
    public class GlobalClaimsAuthenticationManager : ClaimsAuthenticationManager
    {
        public override ClaimsPrincipal Authenticate(string resourceName, ClaimsPrincipal incomingPrincipal)
        {
            // NOTE: Add custom logic here
            return base.Authenticate(resourceName, incomingPrincipal);
        }
    }
}
