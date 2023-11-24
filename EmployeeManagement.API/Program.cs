using EmployeeManagement.Core.Interfaces;
using EmployeeManagement.Core.Repository;
using EmployeeManagement.Business.Extension;
using EmployeeManagement.Core.Extension;
using EmployeeManagement.Business.Interfaces;
using EmployeeManagement.Business.Services;
using EmployeeManagement.Infrastructure.Extension;
using EmployeeManagement.API;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.SetupBusinessService();
IConfiguration configuration = builder.Configuration;
builder.Services.AddCoreServices(configuration);
builder.Services.SetupInfrastructureService(configuration);


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
app.UseExceptionHandlingMiddleware();

app.UseAuthorization();

app.MapControllers();

app.Run();
