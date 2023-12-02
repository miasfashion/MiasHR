using MiasHR.Api.Data;
using MiasHR.Api.Repositories;
using MiasHR.Api.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextPool<MiasHRDbContext>(options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
        options.LogTo(Console.WriteLine, LogLevel.Information);
    }
);

builder.Services.AddScoped<IDayTimeOffRequestRepository, DayTimeOffRequestRepository>();
builder.Services.AddScoped<ITimeAttendanceRepository, TimeAttendanceRepository>();
builder.Services.AddScoped<IEmployeeInfoRequestRepository, EmployeeInfoRequestRepository>();
builder.Services.AddScoped<IInsuranceRepository, InsuranceRepository>();
builder.Services.AddScoped<IEvaluationRepository, EvaluationRepository>();
builder.Services.AddScoped<IAuthRepository, AuthRepository>();
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
