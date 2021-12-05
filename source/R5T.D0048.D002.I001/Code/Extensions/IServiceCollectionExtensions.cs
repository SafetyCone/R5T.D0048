using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Lombardy;

using R5T.D0106.D002;
using R5T.T0063;


namespace R5T.D0048.D002.I001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ProcessStartTimeSpecificOutputDirectoryPathProvider"/> implementation of <see cref="IProcessStartTimeSpecificOutputDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddProcessStartTimeSpecificOutputDirectoryPathProvider(this IServiceCollection services,
            IServiceAction<IProcessSpecificOutputDirectoryPathProvider> processSpecificOutputDirectoryPathProviderAction,
            IServiceAction<IProcessStartTimeDirectoryNameProvider> processStartTimeDirectoryNameProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            services
                .Run(processSpecificOutputDirectoryPathProviderAction)
                .Run(processStartTimeDirectoryNameProviderAction)
                .Run(stringlyTypedPathOperatorAction)
                .AddSingleton<IProcessStartTimeSpecificOutputDirectoryPathProvider, ProcessStartTimeSpecificOutputDirectoryPathProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ProcessSpecificOutputDirectoryPathProvider"/> implementation of <see cref="IProcessSpecificOutputDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddProcessSpecificOutputDirectoryPathProvider(this IServiceCollection services,
            IServiceAction<IProcessDirectoryNameProvider> processDirectoryNameProviderAction,
            IServiceAction<IRootOutputDirectoryPathProvider> rootOutputDirectoryPathProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            services
                .Run(processDirectoryNameProviderAction)
                .Run(rootOutputDirectoryPathProviderAction)
                .Run(stringlyTypedPathOperatorAction)
                .AddSingleton<IProcessSpecificOutputDirectoryPathProvider, ProcessSpecificOutputDirectoryPathProvider>();

            return services;
        }
    }
}