using iphound.API.Providers.Service.IpService;

namespace iphound.API.Extensions;

public static class ProviderExtension
{
    public static void AddProviders(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddServices();
        services.AddHttpClient();
    }

    private static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IIpService, IpService>();
    }

    private static void AddHttpClient(this IServiceCollection services)
    {
        services.AddHttpClient<IIpService, IpService>(
            client =>
            {
                client.BaseAddress = new Uri("https://ip2c.org");
            });
    }
}