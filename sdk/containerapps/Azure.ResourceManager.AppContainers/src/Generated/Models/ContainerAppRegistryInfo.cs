// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Container App registry information. </summary>
    public partial class ContainerAppRegistryInfo
    {
        /// <summary> Initializes a new instance of ContainerAppRegistryInfo. </summary>
        public ContainerAppRegistryInfo()
        {
        }

        /// <summary> Initializes a new instance of ContainerAppRegistryInfo. </summary>
        /// <param name="registryServer"> registry server Url. </param>
        /// <param name="registryUserName"> registry username. </param>
        /// <param name="registryPassword"> registry secret. </param>
        internal ContainerAppRegistryInfo(string registryServer, string registryUserName, string registryPassword)
        {
            RegistryServer = registryServer;
            RegistryUserName = registryUserName;
            RegistryPassword = registryPassword;
        }

        /// <summary> registry server Url. </summary>
        public string RegistryServer { get; set; }
        /// <summary> registry username. </summary>
        public string RegistryUserName { get; set; }
        /// <summary> registry secret. </summary>
        public string RegistryPassword { get; set; }
    }
}
