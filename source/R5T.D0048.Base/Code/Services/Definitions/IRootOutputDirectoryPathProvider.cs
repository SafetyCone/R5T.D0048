using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0048
{
    [ServiceDefinitionMarker]
    public interface IRootOutputDirectoryPathProvider : IServiceDefinition
    {
        Task<string> GetRootOutputDirectoryPath();
    }
}
