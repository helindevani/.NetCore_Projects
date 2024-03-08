
namespace MiddleWare.CustomMiddleware

{
    public class Custommiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Custom Middleware Started \n ");
            await next(context);
            await context.Response.WriteAsync("Custom Middleware Stoped \n");
        }
    }

    public static class CustommiddlewareExtention
    {
        public static IApplicationBuilder UseCustommiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<Custommiddleware>();
        }
    }
}
