using Application.Common.DataAccess;
using DataAccess;
using DataAccess.Repositories;
using Microsoft.Data.SqlClient;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Configuración para la conexión con base de datos.
builder.Services.AddTransient<IDbConnection>(p =>
{
    var connectionString = p.GetRequiredService<IConfiguration>()["ConnectionStrings:DefaultConnection"] ?? string.Empty;
    return new SqlConnection(connectionString);
});

//Inyección de dependencias.
builder.Services.AddTransient<DapperHelper>();
builder.Services.AddScoped<ISolicitudRepository, SolicitudRepository>();
builder.Services.AddScoped<IEstadoRepository, EstadoRepository>();
builder.Services.AddScoped<IDbContext, DbContext>();

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