using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0048.D002
{
    [ServiceDefinitionMarker]
    public interface IProcessStartTimeSpecificOutputDirectoryPathProvider : IServiceDefinition
    {
        Task<string> GetProcessStartTimeSpecificOutputDirectoryPath();
    }
}
