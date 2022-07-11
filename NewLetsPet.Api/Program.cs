using NewLetsPet.Domain.Employees;
using NewLetsPet.Domain.Pets;
using NewLetsPet.Domain.Security;
using NewLetsPet.Repositories;
using NewLetsPet.Repositories.Base;
using NewLetsPet.Repositories.Interfaces;
using NewLetsPet.Repositories.Interfaces.Base;
using NewLetsPet.Services;
using NewLetsPet.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
                .AddScoped<IUserService, UserService>()
                .AddScoped<IEmployeeService, EmployeeService>()
                .AddScoped<IUserRepository, UserRepository>()
                .AddScoped<IGuardianService, GuardianService>()
                .AddScoped<IGuardianRepository, GuardianRepository>()
                .AddScoped<IEmployeeRepository, EmployeeRepository>()
                .AddScoped<IBaseRepository<User>, BaseRepository<User>>()
                .AddScoped<IBaseRepository<Guardian>, BaseRepository<Guardian>>()
                .AddScoped<IBaseRepository<Employee>, BaseRepository<Employee>>();

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

