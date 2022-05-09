using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var configuration = new ConfigurationBuilder().AddJsonFile("ocelot.json").Build();
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddOcelot(configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.

await app.UseOcelot();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
