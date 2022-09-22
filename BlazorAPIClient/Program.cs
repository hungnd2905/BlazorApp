using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorAPIClient
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("BlazoreAPIClient has started...");
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["api_base_url"]) });

            await builder.Build().RunAsync();
        }
    }
}