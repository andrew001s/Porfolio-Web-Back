using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using PortfolioAPI.Connections;
using PortfolioAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DBMySQLConnection>(options => options.UseMySQL(builder.Configuration.GetConnectionString("DBMySQLConnection")));
builder.Services.AddScoped<IProyectsServices, ProyectsServices>();
builder.Services.AddScoped<IExperienceServices, ExperienceServices>();

var app = builder.Build();
/*
using (var scope = app.Services.CreateScope())
{
    var context= scope.ServiceProvider.GetRequiredService<DBMySQLConnection>();
    context.Database.Migrate();
}
*/
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.UseAuthorization();

app.MapControllers();

app.Run();
