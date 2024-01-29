using Shop.Microservice.Core;
using Shop.Microservice.Domain.Common.Interfaces;
using Shop.Microservice.Infrastructure;
using Shop.Microservice.Infrastructure.Repositories.Contracts;
using Shop.Microservice.Infrastructure.Repositories.Implementation;
using Shop.Microservice.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DatabaseContext>(); // ����������� AddDbContext, ���� DatabaseContext ������� ���������� � ������������
builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
builder.Services.AddTransient<ProductService>();
builder.Services.AddTransient<OrderService>();
builder.Services.AddTransient<BalanceService>();
builder.Services.AddTransient<TransactionService>();
builder.Services.AddScoped<IProducer, RmqProducer>();
builder.Services.AddControllersWithViews();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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