using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0063;

using R5T.D0048.D002;


namespace R5T.D0048.I002
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="OutputDirectoryPathProvider"/> implementation of <see cref="IOutputDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddOutputDirectoryPathProvider(this IServiceCollection services,
            IServiceAction<IProcessStartTimeSpecificOutputDirectoryPathProvider> processStartTimeSpecificOutputDirectoryPathProviderAction)
        {
            services
                .Run(processStartTimeSpecificOutputDirectoryPathProviderAction)
                .AddSingleton<IOutputDirectoryPathProvider, OutputDirectoryPathProvider>();

            return services;
        }
    }
}