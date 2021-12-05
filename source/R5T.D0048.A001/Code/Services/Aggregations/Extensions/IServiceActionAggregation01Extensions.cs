using System;

using R5T.D0048.A001;


namespace System
{
    public static class IServiceActionAggregation01Extensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceActionAggregation01 other)
            where T : IServiceActionAggregation01
        {
            aggregation.OutputDirectoryPathProviderAction = other.OutputDirectoryPathProviderAction;
            aggregation.OutputFilePathProviderAction = other.OutputFilePathProviderAction;
            aggregation.ProcessDirectoryNameProviderAction = other.ProcessDirectoryNameProviderAction;
            aggregation.ProcessSpecificOutputDirectoryPathProviderAction = other.ProcessSpecificOutputDirectoryPathProviderAction;
            aggregation.ProcessStartTimeDirectoryNameProviderAction = other.ProcessStartTimeDirectoryNameProviderAction;
            aggregation.ProcessStartTimeSpecificOutputDirectoryPathProviderAction = other.ProcessStartTimeSpecificOutputDirectoryPathProviderAction;

            return aggregation;
        }
    }
}
