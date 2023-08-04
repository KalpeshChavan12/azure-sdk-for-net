// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.AppContainers;
using Azure.ResourceManager.AppContainers.Models;

namespace Azure.ResourceManager.AppContainers.Samples
{
    public partial class Sample_ContainerAppConnectedEnvironmentDaprComponentCollection
    {
        // List Dapr Components
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListDaprComponents()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2023-04-01-preview/examples/ConnectedEnvironmentsDaprComponents_List.json
            // this example is just showing the usage of "ConnectedEnvironmentsDaprComponents_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppConnectedEnvironmentResource created on azure
            // for more information of creating ContainerAppConnectedEnvironmentResource, please refer to the document of ContainerAppConnectedEnvironmentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string connectedEnvironmentName = "myenvironment";
            ResourceIdentifier containerAppConnectedEnvironmentResourceId = ContainerAppConnectedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, connectedEnvironmentName);
            ContainerAppConnectedEnvironmentResource containerAppConnectedEnvironment = client.GetContainerAppConnectedEnvironmentResource(containerAppConnectedEnvironmentResourceId);

            // get the collection of this ContainerAppConnectedEnvironmentDaprComponentResource
            ContainerAppConnectedEnvironmentDaprComponentCollection collection = containerAppConnectedEnvironment.GetContainerAppConnectedEnvironmentDaprComponents();

            // invoke the operation and iterate over the result
            await foreach (ContainerAppConnectedEnvironmentDaprComponentResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerAppDaprComponentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Dapr Component
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetDaprComponent()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2023-04-01-preview/examples/ConnectedEnvironmentsDaprComponents_Get.json
            // this example is just showing the usage of "ConnectedEnvironmentsDaprComponents_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppConnectedEnvironmentResource created on azure
            // for more information of creating ContainerAppConnectedEnvironmentResource, please refer to the document of ContainerAppConnectedEnvironmentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string connectedEnvironmentName = "myenvironment";
            ResourceIdentifier containerAppConnectedEnvironmentResourceId = ContainerAppConnectedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, connectedEnvironmentName);
            ContainerAppConnectedEnvironmentResource containerAppConnectedEnvironment = client.GetContainerAppConnectedEnvironmentResource(containerAppConnectedEnvironmentResourceId);

            // get the collection of this ContainerAppConnectedEnvironmentDaprComponentResource
            ContainerAppConnectedEnvironmentDaprComponentCollection collection = containerAppConnectedEnvironment.GetContainerAppConnectedEnvironmentDaprComponents();

            // invoke the operation
            string componentName = "reddog";
            ContainerAppConnectedEnvironmentDaprComponentResource result = await collection.GetAsync(componentName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppDaprComponentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Dapr Component
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetDaprComponent()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2023-04-01-preview/examples/ConnectedEnvironmentsDaprComponents_Get.json
            // this example is just showing the usage of "ConnectedEnvironmentsDaprComponents_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppConnectedEnvironmentResource created on azure
            // for more information of creating ContainerAppConnectedEnvironmentResource, please refer to the document of ContainerAppConnectedEnvironmentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string connectedEnvironmentName = "myenvironment";
            ResourceIdentifier containerAppConnectedEnvironmentResourceId = ContainerAppConnectedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, connectedEnvironmentName);
            ContainerAppConnectedEnvironmentResource containerAppConnectedEnvironment = client.GetContainerAppConnectedEnvironmentResource(containerAppConnectedEnvironmentResourceId);

            // get the collection of this ContainerAppConnectedEnvironmentDaprComponentResource
            ContainerAppConnectedEnvironmentDaprComponentCollection collection = containerAppConnectedEnvironment.GetContainerAppConnectedEnvironmentDaprComponents();

            // invoke the operation
            string componentName = "reddog";
            bool result = await collection.ExistsAsync(componentName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Create or update dapr component
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateDaprComponent()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2023-04-01-preview/examples/ConnectedEnvironmentsDaprComponents_CreateOrUpdate.json
            // this example is just showing the usage of "ConnectedEnvironmentsDaprComponents_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerAppConnectedEnvironmentResource created on azure
            // for more information of creating ContainerAppConnectedEnvironmentResource, please refer to the document of ContainerAppConnectedEnvironmentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string connectedEnvironmentName = "myenvironment";
            ResourceIdentifier containerAppConnectedEnvironmentResourceId = ContainerAppConnectedEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, connectedEnvironmentName);
            ContainerAppConnectedEnvironmentResource containerAppConnectedEnvironment = client.GetContainerAppConnectedEnvironmentResource(containerAppConnectedEnvironmentResourceId);

            // get the collection of this ContainerAppConnectedEnvironmentDaprComponentResource
            ContainerAppConnectedEnvironmentDaprComponentCollection collection = containerAppConnectedEnvironment.GetContainerAppConnectedEnvironmentDaprComponents();

            // invoke the operation
            string componentName = "reddog";
            ContainerAppDaprComponentData data = new ContainerAppDaprComponentData()
            {
                ComponentType = "state.azure.cosmosdb",
                Version = "v1",
                IgnoreErrors = false,
                InitTimeout = "50s",
                Secrets =
{
new ContainerAppWritableSecret()
{
Name = "masterkey",
Value = "keyvalue",
}
},
                Metadata =
{
new ContainerAppDaprMetadata()
{
Name = "url",
Value = "<COSMOS-URL>",
},new ContainerAppDaprMetadata()
{
Name = "database",
Value = "itemsDB",
},new ContainerAppDaprMetadata()
{
Name = "collection",
Value = "items",
},new ContainerAppDaprMetadata()
{
Name = "masterkey",
SecretRef = "masterkey",
}
},
                Scopes =
{
"container-app-1","container-app-2"
},
            };
            ArmOperation<ContainerAppConnectedEnvironmentDaprComponentResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, componentName, data);
            ContainerAppConnectedEnvironmentDaprComponentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppDaprComponentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
