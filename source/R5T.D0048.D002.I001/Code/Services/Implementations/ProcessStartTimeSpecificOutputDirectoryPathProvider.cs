using System;
using System.Threading.Tasks;

using R5T.Lombardy;

using R5T.D0106.D002;
using R5T.T0064;


namespace R5T.D0048.D002.I001
{
    [ServiceImplementationMarker]
    public class ProcessStartTimeSpecificOutputDirectoryPathProvider : IProcessStartTimeSpecificOutputDirectoryPathProvider, IServiceImplementation
    {
        private IProcessSpecificOutputDirectoryPathProvider ProcessSpecificOutputDirectoryPathProvider { get; }
        private IProcessStartTimeDirectoryNameProvider ProcessStartTimeDirectoryNameProvider { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public ProcessStartTimeSpecificOutputDirectoryPathProvider(
            IProcessSpecificOutputDirectoryPathProvider processSpecificOutputDirectoryPathProvider,
            IProcessStartTimeDirectoryNameProvider processStartTimeDirectoryNameProvider,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.ProcessSpecificOutputDirectoryPathProvider = processSpecificOutputDirectoryPathProvider;
            this.ProcessStartTimeDirectoryNameProvider = processStartTimeDirectoryNameProvider;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public async Task<string> GetProcessStartTimeSpecificOutputDirectoryPath()
        {
            var (processSpecificOutputDirectoryPath, startTimeDirectoryName) = await TaskHelper.WhenAll(
                this.ProcessSpecificOutputDirectoryPathProvider.GetProcessSpecificOutputDirectoryPath(),
                this.ProcessStartTimeDirectoryNameProvider.GetProcessStartTimeDirectoryName());

            var output = this.StringlyTypedPathOperator.GetDirectoryPath(
                processSpecificOutputDirectoryPath,
                startTimeDirectoryName);

            return output;
        }
    }
}
