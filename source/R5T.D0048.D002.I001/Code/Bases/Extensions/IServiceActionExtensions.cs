using System;

using R5T.Lombardy;

using R5T.D0106.D002;
using R5T.T0062;
using R5T.T0063;


namespace R5T.D0048.D002.I001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ProcessStartTimeSpecificOutputDirectoryPathProvider"/> implementation of <see cref="IProcessStartTimeSpecificOutputDirectoryPathProvider"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IProcessStartTimeSpecificOutputDirectoryPathProvider> AddProcessStartTimeSpecificOutputDirectoryPathProviderAction(this IServiceAction _,
            IServiceAction<IProcessSpecificOutputDirectoryPathProvider> processSpecificOutputDirectoryPathProviderAction,
            IServiceAction<IProcessStartTimeDirectoryNameProvider> processStartTimeDirectoryNameProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var serviceAction = _.New<IProcessStartTimeSpecificOutputDirectoryPathProvider>(services => services.AddProcessStartTimeSpecificOutputDirectoryPathProvider(
                processSpecificOutputDirectoryPathProviderAction,
                processStartTimeDirectoryNameProviderAction,
                stringlyTypedPathOperatorAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="ProcessSpecificOutputDirectoryPathProvider"/> implementation of <see cref="IProcessSpecificOutputDirectoryPathProvider"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IProcessSpecificOutputDirectoryPathProvider> AddProcessSpecificOutputDirectoryPathProviderAction(this IServiceAction _,
            IServiceAction<IProcessDirectoryNameProvider> processDirectoryNameProviderAction,
            IServiceAction<IRootOutputDirectoryPathProvider> rootOutputDirectoryPathProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var serviceAction = _.New<IProcessSpecificOutputDirectoryPathProvider>(services => services.AddProcessSpecificOutputDirectoryPathProvider(
                processDirectoryNameProviderAction,
                rootOutputDirectoryPathProviderAction,
                stringlyTypedPathOperatorAction));

            return serviceAction;
        }
    }
}
