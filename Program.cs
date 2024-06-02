using api_vehicle_rental.Context;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Verifica e configura a cultura invariante
var globalizationInvariant = Environment.GetEnvironmentVariable("DOTNET_SYSTEM_GLOBALIZATION_INVARIANT");
Console.WriteLine($"DOTNET_SYSTEM_GLOBALIZATION_INVARIANT: {globalizationInvariant}");

if (globalizationInvariant?.ToLower() != "false")
{
    CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
    CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;
}

builder.Services.AddDbContext<RentalVehiclesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("StandardConnection") + ";TrustServerCertificate=True"));

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
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
app.MapControllers();
app.Run();
