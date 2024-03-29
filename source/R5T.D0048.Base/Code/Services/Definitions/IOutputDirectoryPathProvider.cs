﻿using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0048
{
    /// <summary>
    /// Provides the directory path for an general output directory.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IOutputDirectoryPathProvider : IServiceDefinition
    {
        Task<string> GetOutputDirectoryPath();
    }
}
