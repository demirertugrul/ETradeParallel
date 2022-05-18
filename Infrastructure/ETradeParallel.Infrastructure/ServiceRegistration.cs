using ETradeParallel.Application.Services;
using ETradeParallel.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ETradeParallel.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IFileService, FileService>();
        }
    }
}
