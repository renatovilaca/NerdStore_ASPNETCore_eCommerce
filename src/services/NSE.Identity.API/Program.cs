using NSE.Identity.API.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerConfiguration();
builder.Services.AddApiConfiguration();
builder.Services.AddIdentityConfiguration(builder.Configuration);

/*
ConfigurationManager configuration = builder.Configuration;
IWebHostEnvironment environment = builder.Environment;

var config = new ConfigurationBuilder()
    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
    .AddJsonFile("appsettings.json", true, true)
    .AddJsonFile($"appsettings.{environment.EnvironmentName}.json", true, true)
    .AddEnvironmentVariables()
    .Build();
*/

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwaggerConfiguration();
}

app.UseApiConfiguration();

app.Run();
