using Microsoft.Extensions.DependencyInjection;

namespace SLB.Log.Providers.Serilog
{
    public static class ServiceProviderExtensions
    {
        public static void AddSerilog(this IServiceCollection services)
        {
            services.AddSingleton<ILogger, SerilogLogger>();
        }
    }
}
