using System;

using R5T.T0062;
using R5T.T0063;

using R5T.D0048.D002;


namespace R5T.D0048.I002
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="OutputDirectoryPathProvider"/> implementation of <see cref="IOutputDirectoryPathProvider"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IOutputDirectoryPathProvider> AddOutputDirectoryPathProviderAction(this IServiceAction _,
            IServiceAction<IProcessStartTimeSpecificOutputDirectoryPathProvider> processStartTimeSpecificOutputDirectoryPathProviderAction)
        {
            var serviceAction = _.New<IOutputDirectoryPathProvider>(services => services.AddOutputDirectoryPathProvider(
                processStartTimeSpecificOutputDirectoryPathProviderAction));

            return serviceAction;
        }
    }
}
