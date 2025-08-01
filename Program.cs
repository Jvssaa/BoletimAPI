using Microsoft.EntityFrameworkCore;
using BoletimAPI.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BoletimContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Conection")));
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}dsadsad

app.UseHttpsRedirection();


app.MapControllers();

app.Run();

