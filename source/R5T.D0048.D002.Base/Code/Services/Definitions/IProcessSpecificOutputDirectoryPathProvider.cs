using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0048.D002
{
    public interface IProcessSpecificOutputDirectoryPathProvider
    {
        Task<string> GetProcessSpecificOutputDirectoryPath();
    }
}
