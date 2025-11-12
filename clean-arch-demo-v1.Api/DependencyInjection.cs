using clean_arch_demo_v1.Application;
using clean_arch_demo_v1.Infrastructure;

namespace clean_arch_demo_v1.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiDI(this IServiceCollection services)
        {
            services.AddApplicationDI()
                    .AddInfrastructureDI();

            return services;
        }
    }
}
