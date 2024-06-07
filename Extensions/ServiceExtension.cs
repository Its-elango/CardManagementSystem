using CardManagementSystem.Repository;
using CardManagementSystem.Repository.Interface;

namespace CardManagementSystem.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddTransient<ICardTransaction,CardTransactionRepository>();
            services.AddTransient<Connection>();
            return services;
        }

        public static IServiceCollection RegisterClientApi(this IServiceCollection services)
        {
            services.AddHttpClient();
            //services.AddTransient<InvokeApi>();
            return services;
        }
    }
}
