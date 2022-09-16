

using LoggerService;

namespace Stock_API.Extension
{
    public static class ServiceExtension
    {
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }
    }
}