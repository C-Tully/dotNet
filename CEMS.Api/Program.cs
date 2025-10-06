using CEMS.Api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//Register SQL Server Connection
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//Add services to Container.
builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowVueDev", policy =>
    {
        policy.WithOrigins("http://localhost:8080")
        .AllowAnyHeader()
        .AllowAnyMethod();
    });    
});


var app = builder.Build();

//Use CORS
app.UseCors("AllowVueDev");



app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();


