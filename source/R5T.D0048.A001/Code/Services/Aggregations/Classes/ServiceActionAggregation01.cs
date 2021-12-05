using System;

using R5T.D0106.D002;
using R5T.T0063;

using R5T.D0048.D002;


namespace R5T.D0048.A001
{
    public class ServiceActionAggregation01 : IServiceActionAggregation01
    {
        public IServiceAction<IProcessDirectoryNameProvider> ProcessDirectoryNameProviderAction { get; set; }
        public IServiceAction<IProcessSpecificOutputDirectoryPathProvider> ProcessSpecificOutputDirectoryPathProviderAction { get; set; }
        public IServiceAction<IProcessStartTimeDirectoryNameProvider> ProcessStartTimeDirectoryNameProviderAction { get; set; }
        public IServiceAction<IProcessStartTimeSpecificOutputDirectoryPathProvider> ProcessStartTimeSpecificOutputDirectoryPathProviderAction { get; set; }
        public IServiceAction<IOutputDirectoryPathProvider> OutputDirectoryPathProviderAction { get; set; }
        public IServiceAction<IOutputFilePathProvider> OutputFilePathProviderAction { get; set; }
    }
}
