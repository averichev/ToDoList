namespace App;

internal static class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    private static IHostBuilder CreateHostBuilder(string[] args) =>
        Host
            .CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
}

// var builder = WebApplication.CreateBuilder(args);
//
// var services = builder.Services;
//

//
// var app = builder.Build();
//

//
// app.Run();