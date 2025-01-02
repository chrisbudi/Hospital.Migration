using Microsoft.EntityFrameworkCore;
using Wincare.Pendaftaran.Migration.Models;
using Wincare.Pendaftaran.Migration.NewModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<WinCare2Context>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("oldConnection")));

builder.Services.AddDbContext<SimpleContext>(
    options => options.UseNpgsql(builder.Configuration.GetConnectionString("clinicConnection")));



var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
