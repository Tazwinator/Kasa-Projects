using Microsoft.EntityFrameworkCore;
using TMDb.AppDataAPI;
using TMDb.DataAccess.Data;

var seed = args.Contains("/seed");
if (seed)
{
    args = args.Except(new[] { "/seed" }).ToArray();
}

var builder = WebApplication.CreateBuilder(args);

var defaultConnString = builder.Configuration.GetConnectionString("DefaultConnection");

if (seed)
{
    SeedDb.Seed(defaultConnString);
}

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(defaultConnString));

builder.Services.AddMemoryCache();

builder.Services.AddHttpClient();


if (builder.Environment.IsDevelopment())
{
    builder.Services.AddSwaggerGen();
}
else
{
    builder.Services.AddSwaggerGen(config =>
    {
        config.SwaggerDoc("AppData", new Microsoft.OpenApi.Models.OpenApiInfo
        {
            Title = "AppData",
            Version = "v1"
        });
    });
}


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
