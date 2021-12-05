using System;

using R5T.Lombardy;

using R5T.D0103;
using R5T.D0106;
using R5T.D0106.D002;
using R5T.D0106.D002.I001;
using R5T.D0107;
using R5T.T0062;
using R5T.T0063;

using R5T.D0048.D002.I001;
using R5T.D0048.Default;
using R5T.D0048.I002;


namespace R5T.D0048.A001
{
    public static class IServiceActionExtensions
    {
        public static IServiceActionAggregation01 AddOutputFilePathProviderActions(this IServiceAction _,
            IServiceAction<IDateTimeDirectoryNameProvider> dateTimeDirectoryNameProviderAction,
            IServiceAction<IDirectoryNameProvider> directoryNameProviderAction,
            IServiceAction<IProcessNameProvider> processNameProviderAction,
            IServiceAction<IProcessStartTimeProvider> processStartTimeProviderAction,
            IServiceAction<IRootOutputDirectoryPathProvider> rootOutputDirectoryPathProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var processDirectoryNameProviderAction = _.AddProcessDirectoryNameProviderAction(
                processNameProviderAction,
                directoryNameProviderAction);

            var processSpecificOutputDirectoryPathProviderAction = _.AddProcessSpecificOutputDirectoryPathProviderAction(
                processDirectoryNameProviderAction,
                rootOutputDirectoryPathProviderAction,
                stringlyTypedPathOperatorAction);

            var processStartTimeDirectoryNameProviderAction = _.AddProcessStartTimeDirectoryNameProviderAction(
                processStartTimeProviderAction,
                dateTimeDirectoryNameProviderAction);

            var processStartTimeSpecificOutputDirectoryPathProviderAction = _.AddProcessStartTimeSpecificOutputDirectoryPathProviderAction(
                processSpecificOutputDirectoryPathProviderAction,
                processStartTimeDirectoryNameProviderAction,
                stringlyTypedPathOperatorAction);

            var outputDirectoryPathProviderAction = _.AddOutputDirectoryPathProviderAction(
                processStartTimeSpecificOutputDirectoryPathProviderAction);

            var outputFilePathProviderAction = _.AddOutputFilePathProviderAction(
                outputDirectoryPathProviderAction,
                stringlyTypedPathOperatorAction);

            var output = new ServiceActionAggregation01
            {
                OutputDirectoryPathProviderAction = outputDirectoryPathProviderAction,
                OutputFilePathProviderAction = outputFilePathProviderAction,
                ProcessDirectoryNameProviderAction = processDirectoryNameProviderAction,
                ProcessSpecificOutputDirectoryPathProviderAction = processSpecificOutputDirectoryPathProviderAction,
                ProcessStartTimeDirectoryNameProviderAction = processStartTimeDirectoryNameProviderAction,
                ProcessStartTimeSpecificOutputDirectoryPathProviderAction = processStartTimeSpecificOutputDirectoryPathProviderAction,
            };
            return output;
        }
    }
}
