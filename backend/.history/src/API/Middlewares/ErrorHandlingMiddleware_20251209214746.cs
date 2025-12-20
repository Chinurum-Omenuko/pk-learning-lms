using System.Net;
using System.Text.Json;

namespace backend.Src.API.Middlewares;

public class ErrorHandlingMiddleware
{
    private readonly RequestDelegate _next;
    public ErrorHandlingMiddleware(RequestDelegate next) => _next = next;

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            var response = context.Response;
            response.StatusCode = (int)HttpStatusCode.InternalServerError;
            response.ContentType = "application/json";

            await response.WriteAsync(JsonSerializer.Serialize(new
            {
                error = ex.Message,
                stack = ex.StackTrace
            }));
        }
    }
}
