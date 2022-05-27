using ETradeAPI.Infrastructure.Services.Storage.Local;
using ETradeParallel.Application.Abstractions.Storage;
using ETradeParallel.Infrastructure.Enums;
using ETradeParallel.Infrastructure.Services.Storage;
using Microsoft.Extensions.DependencyInjection;

namespace ETradeParallel.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IStorageService, StorageService>();
        }

        public static void AddStorage<T>(this IServiceCollection services) where T : class, IStorage
        {
            services.AddScoped<IStorage, T>();
        }

        public static void AddStorage(this IServiceCollection services, StorageType storageType)
        {
            switch (storageType)
            {
                case StorageType.Local:
                    services.AddScoped<IStorage, LocalStorage>();
                    break;
                case StorageType.Azure:
                    //services.AddScoped<IStorage, LocalStorage>();
                    break;
                case StorageType.AWS:
                    //services.AddScoped<IStorage, LocalStorage>();
                    break;
                default:
                    services.AddScoped<IStorage, LocalStorage>();
                    break;
            }
        }
    }
}
