
using ClientApp;
using ClientApp.Middlewares;
using ClientApp.Services;
using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddTransient<JsonService>();
builder.Services.AddTransient<RequestService>();

builder.Services.AddControllers().AddJsonOptions(options => {
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
}); 
builder.Services.AddControllersWithViews().AddJsonOptions(options => {
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
});
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseStaticFiles();
app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCookiePolicy();

app.UseAuthentication();

app.Use(async (context, next) =>
{
    var token = context.Request.Cookies[".AspNetCore.User.Id"];
    if (!string.IsNullOrEmpty(token))
        context.Request.Headers.Add("Authorization", "Bearer " + token);

    await next();
});

app.UseMiddleware<UserMiddleware>();

app.MapControllers();

app.Run();
