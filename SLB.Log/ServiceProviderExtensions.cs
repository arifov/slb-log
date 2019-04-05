using Microsoft.Extensions.DependencyInjection;

namespace SLB.Log
{
    public static class ServiceProviderExtensions
    {
        public static void AddSlbLog(this IServiceCollection services)
        {
            services.AddSingleton<ILogManager, LogManager>();
        }
    }
}
