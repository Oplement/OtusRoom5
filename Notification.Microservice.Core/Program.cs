using Notification.Microservice.Core.Interfaces;
using Notification.Microservice.Core.Services;
using Notification.Microservice.Core.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Добавление EmailService в контейнер служб
builder.Services.AddScoped<IEmailService, EmailService>();

// Добавление декоратора LoggingEmailServiceDecorator
builder.Services.Decorate<IEmailService, LoggingEmailServiceDecorator>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHostedService<Consumer>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();