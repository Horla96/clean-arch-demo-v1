using clean_arch_demo_v1.Application;
using clean_arch_demo_v1.Infrastructure;
using clean_arch_demo_v1.Core;

namespace clean_arch_demo_v1.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiDI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplicationDI()
                    .AddInfrastructureDI()
                   .AddCoreDI(configuration);

            return services;
        }
    }
}
