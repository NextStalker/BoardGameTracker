using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace BGT.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        private const string DATABASE_SETTINGS_SECTION_NAME = "DatabaseSettings";

        public static IServiceCollection ConfigureDbContextFactory<T>(
            this IServiceCollection services,
            IConfiguration configuration,
            Action<DbContextOptionsBuilder> contextOptionsConfigurator,
            string databaseSettingsSectionName,
            params Assembly[] assemblies)
            where T : DbContext
        {
            const string connectionStringName = "ConnectionString";

            var databaseSettings = configuration.GetSection(databaseSettingsSectionName);
            var connectionString = databaseSettings.GetValue<string>(connectionStringName)!;

            services.AddDbContextFactory<T>(optionsBuilder =>
            {

                optionsBuilder
                    .UseSqlServer(connectionString);
                
                contextOptionsConfigurator.Invoke(optionsBuilder);
            });

            return services;
        }
    }
}
