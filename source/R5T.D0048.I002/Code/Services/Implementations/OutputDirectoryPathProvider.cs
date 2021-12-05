using System;
using System.Threading.Tasks;

using R5T.D0048;
using R5T.T0064;

using R5T.D0048.D002;


namespace R5T.D0048.I002
{
    [ServiceImplementationMarker]
    public class OutputDirectoryPathProvider : IOutputDirectoryPathProvider, IServiceImplementation
    {
        private IProcessStartTimeSpecificOutputDirectoryPathProvider ProcessStartTimeSpecificOutputDirectoryPathProvider { get; }


        public OutputDirectoryPathProvider(
            IProcessStartTimeSpecificOutputDirectoryPathProvider processStartTimeSpecificOutputDirectoryPathProvider)
        {
            this.ProcessStartTimeSpecificOutputDirectoryPathProvider = processStartTimeSpecificOutputDirectoryPathProvider;
        }

        public async Task<string> GetOutputDirectoryPath()
        {
            var output = await this.ProcessStartTimeSpecificOutputDirectoryPathProvider.GetProcessStartTimeSpecificOutputDirectoryPath();
            return output;
        }
    }
}
