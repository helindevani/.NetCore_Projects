using Microsoft.Extensions.Primitives;
using System.IO;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext contex) => {
    /*
     
    contex.Response.Headers["Content-Type"] = "text/html";
    if (contex.Request.Method == "GET")
    {
        if (contex.Request.Headers.ContainsKey("Authorizationkey"))
        {
            string useragent = contex.Request.Headers["Authorizationkey"];
            await contex.Response.WriteAsync($"<h1> {useragent} </h1>");
        }
    }

    if (1 == 1)
    {
        context.Response.StatusCode = 200;
    }
    else
    {
        context.Response.StatusCode = 400;
    }
    string path = context.Request.Path;
    string method = context.Request.Method;
    // context.Response.Headers["MyKey"] = "my value";
    // context.Response.Headers["Server"] = "My Server";
    

    context.Response.Headers["Content-Type"] = "text/html";
    */


    StreamReader reader = new StreamReader(contex.Request.Body);
    string body =await reader.ReadToEndAsync();

    Dictionary<string, StringValues> readdix= Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery(body);

    if (readdix.ContainsKey("firstname"))
    {
        string firstname = readdix["firstname"][0];
        await contex.Response.WriteAsync(firstname);
    }


});

app.Run();
