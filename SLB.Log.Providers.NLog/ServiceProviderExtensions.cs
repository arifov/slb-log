using Microsoft.Extensions.DependencyInjection;

namespace SLB.Log.Providers.NLog
{
    public static class ServiceProviderExtensions
    {
        public static void AddNLog(this IServiceCollection services)
        {
            services.AddSingleton<ILogger, NLogLogger>();
        }
    }
}
