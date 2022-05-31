using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EdenWorks.Application.Extensions
{
    /// <summary>
    ///  A simple static class to catch logged user's information via ClaimsPrincipal.
    /// </summary>
    public static class ClaimPrincipalExtensions
    {
        public static string GetUserId(this ClaimsPrincipal claimsPrincipal)
        {
            return claimsPrincipal.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
