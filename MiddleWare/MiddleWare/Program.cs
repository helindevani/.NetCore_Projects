using MiddleWare.CustomMiddleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<Custommiddleware>();
var app = builder.Build();

app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("hello\n");
    await next(context);
});

//app.UseCustommiddleware();

app.UseHelloCustomMiddleware();

app.UseWhen(context => context.Request.Query.ContainsKey("username"),
    app => app.Use(async (HttpContext context, RequestDelegate next) =>
    {
        await context.Response.WriteAsync("Good Morning\n");
        await next(context);
    })
);

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("hello again and again\n");
});

app.Run();
