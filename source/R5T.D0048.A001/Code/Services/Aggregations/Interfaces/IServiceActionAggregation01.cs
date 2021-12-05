using System;

using R5T.D0106.D002;
using R5T.T0063;

using R5T.D0048.D002;


namespace R5T.D0048.A001
{
    /// <summary>
    /// Aggregation for <see cref="Default.OutputFilePathProvider"/>.
    /// </summary>
    public interface IServiceActionAggregation01
    {
        IServiceAction<IProcessDirectoryNameProvider> ProcessDirectoryNameProviderAction { get; set; }
        IServiceAction<IProcessSpecificOutputDirectoryPathProvider> ProcessSpecificOutputDirectoryPathProviderAction { get; set; }
        IServiceAction<IProcessStartTimeDirectoryNameProvider> ProcessStartTimeDirectoryNameProviderAction { get; set; }
        IServiceAction<IProcessStartTimeSpecificOutputDirectoryPathProvider> ProcessStartTimeSpecificOutputDirectoryPathProviderAction { get; set; }
        IServiceAction<IOutputDirectoryPathProvider> OutputDirectoryPathProviderAction { get; set; }
        IServiceAction<IOutputFilePathProvider> OutputFilePathProviderAction { get; set; }
    }
}
