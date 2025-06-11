using mai_website_backend;
using mai_website_backend.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Load .env
var root = Directory.GetCurrentDirectory();
var dotenv = Path.Combine(root, ".env");
DotEnv.Load(dotenv);

// Get connection to MySQL DB
builder.Services.AddDbContext<ApplicationDBContext>(options => {
    var connectionString = "Server=" + Environment.GetEnvironmentVariable("db_host") + ";"
                            + "Database=" + Environment.GetEnvironmentVariable("db_name") + ";"
                            + "User=" + Environment.GetEnvironmentVariable("db_username") + ";"
                            + "Password=" + Environment.GetEnvironmentVariable("db_password") + ";"
                            + "Port=" + Environment.GetEnvironmentVariable("db_port") + ";";
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

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
