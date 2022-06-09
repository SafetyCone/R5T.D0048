using System;

using R5T.Lombardy;

using R5T.T0062;
using R5T.T0063;


namespace R5T.D0048.Default
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="StaticValuedRootOutputDirectoryPathProvider"/> implementation of <see cref="IRootOutputDirectoryPathProvider"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IRootOutputDirectoryPathProvider> AddStaticValuedRootOutputDirectoryPathProviderAction(this IServiceAction _)
        {
            var serviceAction = _.New<IRootOutputDirectoryPathProvider>(services => services.AddStaticValuedRootOutputDirectoryPathProvider());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="ConstructorBasedRootOutputDirectoryPathProvider"/> implementation of <see cref="IRootOutputDirectoryPathProvider"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IRootOutputDirectoryPathProvider> AddConstructorBasedRootOutputDirectoryPathProviderAction(this IServiceAction _,
            string rootOutputDirectoryPath)
        {
            var serviceAction = _.New<IRootOutputDirectoryPathProvider>(services => services.AddConstructorBasedRootOutputDirectoryPathProvider(
                rootOutputDirectoryPath));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="OutputFilePathProvider"/> implementation of <see cref="IOutputFilePathProvider"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IOutputFilePathProvider> AddOutputFilePathProviderAction(this IServiceAction _,
            IServiceAction<IOutputDirectoryPathProvider> outputDirectoryPathProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var serviceAction = _.New<IOutputFilePathProvider>(services => services.AddOutputFilePathProvider(
                outputDirectoryPathProviderAction,
                stringlyTypedPathOperatorAction));

            return serviceAction;
        }
    }
}
