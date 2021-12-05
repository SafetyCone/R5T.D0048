using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Lombardy;

using R5T.T0063;


namespace R5T.D0048.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ConstructorBasedRootOutputDirectoryPathProvider"/> implementation of <see cref="IRootOutputDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddConstructorBasedRootOutputDirectoryPathProvider(this IServiceCollection services,
            string rootOutputDirectoryPath)
        {
            services.AddSingleton<IRootOutputDirectoryPathProvider>(_ => new ConstructorBasedRootOutputDirectoryPathProvider(
                rootOutputDirectoryPath));

            return services;
        }

        /// <summary>
        /// Adds the <see cref="StaticValuedRootOutputDirectoryPathProvider"/> implementation of <see cref="IRootOutputDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddStaticValuedRootOutputDirectoryPathProvider(this IServiceCollection services)
        {
            services.AddSingleton<IRootOutputDirectoryPathProvider, StaticValuedRootOutputDirectoryPathProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="OutputFilePathProvider"/> implementation of <see cref="IOutputFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddOutputFilePathProvider(this IServiceCollection services,
            IServiceAction<IOutputDirectoryPathProvider> outputDirectoryPathProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            services
                .Run(outputDirectoryPathProviderAction)
                .Run(stringlyTypedPathOperatorAction)
                .AddSingleton<IOutputFilePathProvider, OutputFilePathProvider>();

            return services;
        }
    }
}
