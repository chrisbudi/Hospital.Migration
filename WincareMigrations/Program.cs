using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using WincareMigrations.Models;
using WincareMigrations.NewModels;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<WinCare2Context>(
       options => options.UseSqlServer(builder.Configuration.GetConnectionString("oldConnection")));

builder.Services.AddDbContext<SimpleContext>(
       options => options.UseNpgsql(builder.Configuration.GetConnectionString("clinicConnection")));
var services = builder.Services;

services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Api Key Auth", Version = "v1" });
    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // apply migration simple context
    using (var scope = app.Services.CreateScope())
    {
        var servicesScope = scope.ServiceProvider;
        var context = servicesScope.GetRequiredService<SimpleContext>();
        context.Database.Migrate();
    }

    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
