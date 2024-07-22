using System.Reflection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddControllers();
services.AddEndpointsApiExplorer();
services.AddSwaggerGen(
    c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v0.1",
                Title = "Todo list API",
                Description = "Веб-приложение для управления списком задач",
                Contact = new OpenApiContact
                {
                    Name = "Аверичев А.",
                    Url = new Uri("https://github.com/averichev")
                }
            }
        );
        c.ExampleFilters();
        c.OperationFilter<AddResponseHeadersFilter>();
    }
);

services.AddSwaggerExamplesFromAssemblies(Assembly.GetEntryAssembly());

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();