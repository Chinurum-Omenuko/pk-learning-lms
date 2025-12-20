using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;

namespace API.Middlewares;

public class JwtAuthMiddleware : Attribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var user = context.HttpContext.User;
        if (user?.Identity?.IsAuthenticated != true)
            context.HttpContext.Response.StatusCode = StatusCodes.Status401Unauthorized;
    }
}
