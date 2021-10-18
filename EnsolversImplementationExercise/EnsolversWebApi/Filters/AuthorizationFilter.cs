using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using BusinessLogic.Services;

namespace SoftwareIncidentManagerWebApi.Filters
{
    public class AuthorizationFilter : Attribute, IAuthorizationFilter
    {

        private IAuthService authService;

        public AuthorizationFilter(IAuthService authService)
        {
            this.authService = authService;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            string token = context.HttpContext.Request.Headers["auth"];
            if (token == null)
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 401,
                    Content = "Error to autenticate user. He is not register in the system."
                };
                return;
            }
            if (!authService.IsLoggedIn(token))
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 403,
                    Content = "Error to autenticate user. Invalid token."
                };
                return;
            }
        }
    }
}

