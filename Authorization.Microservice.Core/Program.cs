using Authorization.Microservice.Core.JWTSettings;
using Authorization.Microservice.Domain;
using Authorization.Microservice.Infrastructure;
using Authorization.Microservice.Infrastructure.Repositories.Contracts;
using Authorization.Microservice.Infrastructure.Repositories.Implementation;
using Authorization.Microservice.Infrastructure.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder();

builder.Services.AddControllers();
builder.Services.AddAuthorization();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "You api title", Version = "v1" });
    c.AddSecurityDefinition(name: "Bearer", securityScheme: new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Description = "Enter the Bearer Authorization string as following: `Bearer Generated-JWT-Token`",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
{
    {
        new OpenApiSecurityScheme
        {
            Name = "Bearer",
            In = ParameterLocation.Header,
            Reference = new OpenApiReference
            {
                Id = "Bearer",
                Type = ReferenceType.SecurityScheme
            }
        },
        new List<string>()
    }
});

});

builder.Services.AddTransient<DatabaseContext>();
builder.Services.AddTransient<IRepository<User>, AuthRepository<User>>();
builder.Services.AddTransient<AuthService>();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidIssuer = AuthOptions.ISSUER,
            ValidateAudience = true,
            ValidAudience = AuthOptions.AUDIENCE,
            ValidateLifetime = true,
            IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
            ValidateIssuerSigningKey = true,
        };
    });

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder => builder.AllowAnyMethod()
                          .AllowAnyHeader()
                          .SetIsOriginAllowed(_ => true)
                          .AllowCredentials());
});

var app = builder.Build();

app.UseRouting();
app.UseCors("AllowAll");

app.UseDeveloperExceptionPage();

app.UseDefaultFiles();
app.UseStaticFiles();
app.UseSwagger();
app.UseSwaggerUI();
app.UseAuthentication();

app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
