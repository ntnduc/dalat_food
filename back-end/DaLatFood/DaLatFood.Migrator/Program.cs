namespace DaLatFood.Migrator;

public class Program
{
    public static void Main(string[] args) => CreateHostBuilder(args);

    public static IHostBuilder CreateHostBuilder(string[] args)
        => Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
}