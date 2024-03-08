<<<<<<< HEAD
using ModelValidationsExample.CustomModelBinders;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(options =>
{
    options.ModelBinderProviders.Insert(0, new PersonBinderProvider());
}
);
builder.Services.AddControllers().AddXmlSerializerFormatters();//for body in pass xml data
var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
=======
using ModelValidationsExample.CustomModelBinders;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(options =>
{
    options.ModelBinderProviders.Insert(0, new PersonBinderProvider());
}
);
builder.Services.AddControllers().AddXmlSerializerFormatters();//for body in pass xml data
var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
>>>>>>> 84ef70a4525f3b65b6294732992407190e86ba78
