<<<<<<< HEAD
using Microsoft.Extensions.FileProviders;
using Routing.CustomRoutingConstrains;

var builder = WebApplication.CreateBuilder(new WebApplicationOptions()
{
    WebRootPath = "myroot"
});
builder.Services.AddRouting(options =>
{
    options.ConstraintMap.Add("months", typeof(MyContrain));
});
var app = builder.Build();

app.UseStaticFiles();
app.UseStaticFiles(new StaticFileOptions()
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(builder.Environment.ContentRootPath, "mywebroot")
        )

});
/*
app.Use(async (context, next) => {
    Microsoft.AspNetCore.Http.Endpoint? endpoint = context.GetEndpoint();
    if(endpoint != null)
    {
        await context.Response.WriteAsync($"EndPoint : {endpoint.DisplayName}\n");
    }
    await next(context);
});

*/

app.UseRouting();
/*
app.Use(async (context, next) => {
    Microsoft.AspNetCore.Http.Endpoint? endpoint = context.GetEndpoint();
    if (endpoint != null)
    {
        await context.Response.WriteAsync($"EndPoint : {endpoint.DisplayName}\n");
    }
    await next(context);
});
*/
app.UseEndpoints(endpoints =>
{
    /*
    endpoints.MapPost("map1", async (context) =>
    {
        await context.Response.WriteAsync("In map 1");
    });
    endpoints.MapGet("map2", async (context) =>
    {
        await context.Response.WriteAsync("In map 2");
    });
    */
    endpoints.Map("files/{filename}.{extension}", async (context) =>
    {
        string? filename = Convert.ToString(context.Request.RouteValues["filename"]);
        string? extension = Convert.ToString(context.Request.RouteValues["extension"]);
        await context.Response.WriteAsync($"your  filename -> {filename}-{extension}");
    });

    endpoints.Map("employee/profile/{Employeename:minlength(3):maxlength(7)=harsha}", async (context) =>
    {
        string? employeename = Convert.ToString(context.Request.RouteValues["employeename"]);
        await context.Response.WriteAsync($"In EmployeeProfile -> {employeename}");
    });

    endpoints.Map("products/details/{id:int:range(1,1000)?}", async (context) =>
    {
        if (context.Request.RouteValues.ContainsKey("id"))
        {
            int id = Convert.ToInt32(context.Request.RouteValues["id"]);
            await context.Response.WriteAsync($"your id is -> {id}");
        }
        else
        {
            await context.Response.WriteAsync($"your id is -> id will be not provided");
        }
    });

    endpoints.Map("daily-digest-reportdate/{reportDate:datetime}", async (context) =>
    {
        DateTime reportDate = Convert.ToDateTime(context.Request.RouteValues["reportDate"]);
        await context.Response.WriteAsync($"your Date is -> {reportDate.ToShortDateString()}");
    });

    endpoints.Map("cities/{cityid:guid}", async (context) =>
    {
        Guid cityId = Guid.Parse(Convert.ToString(context.Request.RouteValues["cityid"])!);
        await context.Response.WriteAsync($"City Information -> {cityId}");
    });

    endpoints.Map("{year:int:min(1900)}/{month:months}", async context =>
    {
        int year = Convert.ToInt32(context.Request.RouteValues["year"]);
        string? month = Convert.ToString(context.Request.RouteValues["month"]);

        await context.Response.WriteAsync($"year: {year}, month: {month}");

    });

    //2024/may
    endpoints.Map("2024/may", async context =>
    {
        await context.Response.WriteAsync("May 2024 report generated...");
    });
});

app.Run(async (context) => {
    await context.Response.WriteAsync($"Currntly Working on the this Map {context.Request.Path}");
});

app.Run();
=======
using Microsoft.Extensions.FileProviders;
using Routing.CustomRoutingConstrains;

var builder = WebApplication.CreateBuilder(new WebApplicationOptions()
{
    WebRootPath = "myroot"
});
builder.Services.AddRouting(options =>
{
    options.ConstraintMap.Add("months", typeof(MyContrain));
});
var app = builder.Build();

app.UseStaticFiles();
app.UseStaticFiles(new StaticFileOptions()
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(builder.Environment.ContentRootPath, "mywebroot")
        )

});
/*
app.Use(async (context, next) => {
    Microsoft.AspNetCore.Http.Endpoint? endpoint = context.GetEndpoint();
    if(endpoint != null)
    {
        await context.Response.WriteAsync($"EndPoint : {endpoint.DisplayName}\n");
    }
    await next(context);
});

*/

app.UseRouting();
/*
app.Use(async (context, next) => {
    Microsoft.AspNetCore.Http.Endpoint? endpoint = context.GetEndpoint();
    if (endpoint != null)
    {
        await context.Response.WriteAsync($"EndPoint : {endpoint.DisplayName}\n");
    }
    await next(context);
});
*/
app.UseEndpoints(endpoints =>
{
    /*
    endpoints.MapPost("map1", async (context) =>
    {
        await context.Response.WriteAsync("In map 1");
    });
    endpoints.MapGet("map2", async (context) =>
    {
        await context.Response.WriteAsync("In map 2");
    });
    */
    endpoints.Map("files/{filename}.{extension}", async (context) =>
    {
        string? filename = Convert.ToString(context.Request.RouteValues["filename"]);
        string? extension = Convert.ToString(context.Request.RouteValues["extension"]);
        await context.Response.WriteAsync($"your  filename -> {filename}-{extension}");
    });

    endpoints.Map("employee/profile/{Employeename:minlength(3):maxlength(7)=harsha}", async (context) =>
    {
        string? employeename = Convert.ToString(context.Request.RouteValues["employeename"]);
        await context.Response.WriteAsync($"In EmployeeProfile -> {employeename}");
    });

    endpoints.Map("products/details/{id:int:range(1,1000)?}", async (context) =>
    {
        if (context.Request.RouteValues.ContainsKey("id"))
        {
            int id = Convert.ToInt32(context.Request.RouteValues["id"]);
            await context.Response.WriteAsync($"your id is -> {id}");
        }
        else
        {
            await context.Response.WriteAsync($"your id is -> id will be not provided");
        }
    });

    endpoints.Map("daily-digest-reportdate/{reportDate:datetime}", async (context) =>
    {
        DateTime reportDate = Convert.ToDateTime(context.Request.RouteValues["reportDate"]);
        await context.Response.WriteAsync($"your Date is -> {reportDate.ToShortDateString()}");
    });

    endpoints.Map("cities/{cityid:guid}", async (context) =>
    {
        Guid cityId = Guid.Parse(Convert.ToString(context.Request.RouteValues["cityid"])!);
        await context.Response.WriteAsync($"City Information -> {cityId}");
    });

    endpoints.Map("{year:int:min(1900)}/{month:months}", async context =>
    {
        int year = Convert.ToInt32(context.Request.RouteValues["year"]);
        string? month = Convert.ToString(context.Request.RouteValues["month"]);

        await context.Response.WriteAsync($"year: {year}, month: {month}");

    });

    //2024/may
    endpoints.Map("2024/may", async context =>
    {
        await context.Response.WriteAsync("May 2024 report generated...");
    });
});

app.Run(async (context) => {
    await context.Response.WriteAsync($"Currntly Working on the this Map {context.Request.Path}");
});

app.Run();
>>>>>>> 84ef70a4525f3b65b6294732992407190e86ba78
