
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdenWorks.Application.Extensions
{
    /// <summary>
    /// Custom Attribute that checks if user is Authenticated otherwise Redirect user to Login page. 13/5/2022/00/17
    /// </summary>
    public class NeedAuthentication:ActionFilterAttribute
    {
        

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.HttpContext.User.Identity.IsAuthenticated)
            {
                RedirectToLogin(context);
            }
        }

        private void RedirectToLogin (ActionExecutingContext context)
        {
            var redirectPath = new RouteValueDictionary
            {
                {"action","LogIn" },
                {"controller","Account" },

            };
            context.Result = new RedirectToRouteResult(redirectPath);
        }


    }
}
