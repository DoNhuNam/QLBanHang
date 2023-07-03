using Hangfire;
using Infrastructure.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Shared.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace Infrastructure.ScheduledJobs
{
    public static class HangfireExtensions
    {
        public static IServiceCollection AddTeduHangfireService(this IServiceCollection services)
        {
            var settings = services.GetOptions<HangFireSettings>("HangFireSettings");
            if (settings == null || settings.Storage == null ||
                string.IsNullOrEmpty(settings.Storage.ConnectionString))
                throw new Exception("HangFireSettings is not configured properly!");

            services.ConfigureHangfireServices(settings);
            services.AddHangfireServer(serverOptions
                => { serverOptions.ServerName = settings.ServerName; serverOptions.Queues = new[] { "" }; });

            return services;
        }

        private static IServiceCollection ConfigureHangfireServices(this IServiceCollection services,
            HangFireSettings settings)
        {
            if (string.IsNullOrEmpty(settings.Storage.DBProvider))
                throw new Exception("HangFire DBProvider is not configured.");

            switch (settings.Storage.DBProvider.ToLower())
            {
                //case "mongodb":
                //    var mongoUrlBuilder = new MongoUrlBuilder(settings.Storage.ConnectionString);
                //    mongoUrlBuilder.DatabaseName = settings.Storage.DatabaseName;
                //    var mongoClientSettings = MongoClientSettings.FromUrl(
                //        new MongoUrl(settings.Storage.ConnectionString));
                //    mongoClientSettings.SslSettings = new SslSettings
                //    {
                //        EnabledSslProtocols = SslProtocols.Tls12
                //    };
                //    var mongoClient = new MongoClient(mongoClientSettings);
                //    mongoClient.GetDatabase(settings.Storage.DatabaseName);
                //    var mongoStorageOptions = new MongoStorageOptions
                //    {
                //        MigrationOptions = new MongoMigrationOptions
                //        {
                //            MigrationStrategy = new MigrateMongoMigrationStrategy(),
                //            BackupStrategy = new CollectionMongoBackupStrategy()
                //        },
                //        CheckConnection = true,
                //        Prefix = "SchedulerQueue",
                //        CheckQueuedJobsStrategy = CheckQueuedJobsStrategy.TailNotificationsCollection
                //    };
                //    services.AddHangfire((provider, config) =>
                //    {
                //        config.UseSimpleAssemblyNameTypeSerializer()
                //            .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
                //            .UseRecommendedSerializerSettings()
                //            .UseConsole()
                //            .UseMongoStorage(mongoClient, mongoUrlBuilder.DatabaseName, mongoStorageOptions);

                //        var jsonSettings = new JsonSerializerSettings
                //        {
                //            TypeNameHandling = TypeNameHandling.All
                //        };
                //        config.UseSerializerSettings(jsonSettings);
                //    });
                //    services.AddHangfireConsoleExtensions();
                //    break;
                //case "postgresql":
                //    services.AddHangfire(x =>
                //        x.UsePostgreSqlStorage(settings.Storage.ConnectionString));
                //    break;

                case "mssql":
                    services.AddHangfire((a, x) =>
                        x.UseFilter(a.GetRequiredService<AutomaticRetryAttribute>())
                        .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
                        .UseSimpleAssemblyNameTypeSerializer()
                        .UseRecommendedSerializerSettings()
                        .UseSqlServerStorage(settings.Storage.ConnectionString));
                    break;

                default:
                    throw new Exception($"HangFire Storage Provider {settings.Storage.DBProvider} is not supported.");
            }

            return services;
        }
    }
}
