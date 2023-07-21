using Sinuca.Web;
using System.Text.Encodings.Web;
using System.Text.Json;

public class Program
{
    protected Program() { }
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureLogging(logging =>
            {
                logging.ClearProviders();
                logging.AddConsole();
                logging.AddJsonConsole(options =>
                {
                    options.IncludeScopes = false;
                    options.TimestampFormat = "hh:mm:ss ";
                    options.JsonWriterOptions = new JsonWriterOptions
                    {
                        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                    };
                });
            })
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}
