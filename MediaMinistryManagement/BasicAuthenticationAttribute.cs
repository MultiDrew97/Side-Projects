﻿using System;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Threading;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace BasicAuthentication
{
    public class BasicAuthenticationAttribute : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization != null)
            {
                var authToken = actionContext.Request.Headers.Authorization.Parameter;

                // Have to decode the authToken from Base64 in Username:Password format
                var decodeAuthToken = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(authToken));

                // split the token into an array for access
                var userInfo = decodeAuthToken.Split(":");

                if (IsAuthorized(userInfo))
                {
                    Console.WriteLine(userInfo[0]);
                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(userInfo[0]), null);
                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                }
            }
            else
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
            }
        }

        public bool IsAuthorized(string[] auth)
        {
        //TODO: Figure out how to access the users access to the database dynamically
            return auth[0] == "arandlemiller97" && auth[1] == "JasmineLove2697";
        }
    }
}
