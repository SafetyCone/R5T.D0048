using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0048.Default
{
    [ServiceImplementationMarker]
    public class ConstructorBasedRootOutputDirectoryPathProvider : IRootOutputDirectoryPathProvider, IServiceImplementation
    {
        private string RootOutputDirectoryPath { get; }


        public ConstructorBasedRootOutputDirectoryPathProvider(string rootOutputDirectoryPath)
        {
            this.RootOutputDirectoryPath = rootOutputDirectoryPath;
        }

        public Task<string> GetRootOutputDirectoryPath()
        {
            return Task.FromResult(this.RootOutputDirectoryPath);
        }
    }
}
