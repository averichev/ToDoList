using System.Reflection;
using Data;
using Data.Repositories;
using Domain.Interfaces;
using Domain.Services;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;

namespace App;

internal class Startup
{
    public static void ConfigureServices(IServiceCollection services)
    {
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
        
        services.AddDbContext<TodoDbContext>();

        services.AddScoped<ITodoItemService, TodoItemService>();
        services.AddScoped<IUserService, UserService>();
        
        services.AddScoped<ITodoItemRepository, TodoItemRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
    }

    public static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseRouting();
        app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
    }
}