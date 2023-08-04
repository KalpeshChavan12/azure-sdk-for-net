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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppContainers.Samples
{
    public partial class Sample_ContainerAppManagedEnvironmentCollection
    {
        // List environments by resource group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListEnvironmentsByResourceGroup()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2023-04-01-preview/examples/ManagedEnvironments_ListByResourceGroup.json
            // this example is just showing the usage of "ManagedEnvironments_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ContainerAppManagedEnvironmentResource
            ContainerAppManagedEnvironmentCollection collection = resourceGroupResource.GetContainerAppManagedEnvironments();

            // invoke the operation and iterate over the result
            await foreach (ContainerAppManagedEnvironmentResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerAppManagedEnvironmentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get environments by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetEnvironmentsByName()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2023-04-01-preview/examples/ManagedEnvironments_Get.json
            // this example is just showing the usage of "ManagedEnvironments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ContainerAppManagedEnvironmentResource
            ContainerAppManagedEnvironmentCollection collection = resourceGroupResource.GetContainerAppManagedEnvironments();

            // invoke the operation
            string environmentName = "jlaw-demo1";
            ContainerAppManagedEnvironmentResource result = await collection.GetAsync(environmentName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppManagedEnvironmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get environments by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetEnvironmentsByName()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2023-04-01-preview/examples/ManagedEnvironments_Get.json
            // this example is just showing the usage of "ManagedEnvironments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ContainerAppManagedEnvironmentResource
            ContainerAppManagedEnvironmentCollection collection = resourceGroupResource.GetContainerAppManagedEnvironments();

            // invoke the operation
            string environmentName = "jlaw-demo1";
            bool result = await collection.ExistsAsync(environmentName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Create environment with custom infrastructureResourceGroup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateEnvironmentWithCustomInfrastructureResourceGroup()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2023-04-01-preview/examples/ManagedEnvironments_CustomInfrastructureResourceGroup_Create.json
            // this example is just showing the usage of "ManagedEnvironments_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "examplerg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ContainerAppManagedEnvironmentResource
            ContainerAppManagedEnvironmentCollection collection = resourceGroupResource.GetContainerAppManagedEnvironments();

            // invoke the operation
            string environmentName = "testcontainerenv";
            ContainerAppManagedEnvironmentData data = new ContainerAppManagedEnvironmentData(new AzureLocation("East US"))
            {
                DaprAIConnectionString = "InstrumentationKey=00000000-0000-0000-0000-000000000000;IngestionEndpoint=https://northcentralus-0.in.applicationinsights.azure.com/",
                VnetConfiguration = new ContainerAppVnetConfiguration()
                {
                    InfrastructureSubnetId = new ResourceIdentifier("/subscriptions/34adfa4f-cedf-4dc0-ba29-b6d1a69ab345/resourceGroups/RGName/providers/Microsoft.Network/virtualNetworks/VNetName/subnets/subnetName1"),
                },
                AppLogsConfiguration = new ContainerAppLogsConfiguration()
                {
                    LogAnalyticsConfiguration = new ContainerAppLogAnalyticsConfiguration()
                    {
                        CustomerId = "string",
                        SharedKey = "string",
                    },
                },
                IsZoneRedundant = true,
                CustomDomainConfiguration = new ContainerAppCustomDomainConfiguration()
                {
                    DnsSuffix = "www.my-name.com",
                    CertificateValue = Convert.FromBase64String("Y2VydA=="),
                    CertificatePassword = "1234",
                },
                WorkloadProfiles =
{
new ContainerAppWorkloadProfile("My-GP-01","GeneralPurpose")
{
MinimumNodeCount = 3,
MaximumNodeCount = 12,
},new ContainerAppWorkloadProfile("My-MO-01","MemoryOptimized")
{
MinimumNodeCount = 3,
MaximumNodeCount = 6,
},new ContainerAppWorkloadProfile("My-CO-01","ComputeOptimized")
{
MinimumNodeCount = 3,
MaximumNodeCount = 6,
},new ContainerAppWorkloadProfile("My-consumption-01","Consumption")
},
                InfrastructureResourceGroup = "myInfrastructureRgName",
            };
            ArmOperation<ContainerAppManagedEnvironmentResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, environmentName, data);
            ContainerAppManagedEnvironmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppManagedEnvironmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create environments
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateEnvironments()
        {
            // Generated from example definition: specification/app/resource-manager/Microsoft.App/preview/2023-04-01-preview/examples/ManagedEnvironments_CreateOrUpdate.json
            // this example is just showing the usage of "ManagedEnvironments_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "examplerg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ContainerAppManagedEnvironmentResource
            ContainerAppManagedEnvironmentCollection collection = resourceGroupResource.GetContainerAppManagedEnvironments();

            // invoke the operation
            string environmentName = "testcontainerenv";
            ContainerAppManagedEnvironmentData data = new ContainerAppManagedEnvironmentData(new AzureLocation("East US"))
            {
                DaprAIConnectionString = "InstrumentationKey=00000000-0000-0000-0000-000000000000;IngestionEndpoint=https://northcentralus-0.in.applicationinsights.azure.com/",
                VnetConfiguration = new ContainerAppVnetConfiguration()
                {
                    InfrastructureSubnetId = new ResourceIdentifier("/subscriptions/34adfa4f-cedf-4dc0-ba29-b6d1a69ab345/resourceGroups/RGName/providers/Microsoft.Network/virtualNetworks/VNetName/subnets/subnetName1"),
                },
                AppLogsConfiguration = new ContainerAppLogsConfiguration()
                {
                    LogAnalyticsConfiguration = new ContainerAppLogAnalyticsConfiguration()
                    {
                        CustomerId = "string",
                        SharedKey = "string",
                    },
                },
                IsZoneRedundant = true,
                CustomDomainConfiguration = new ContainerAppCustomDomainConfiguration()
                {
                    DnsSuffix = "www.my-name.com",
                    CertificateValue = Convert.FromBase64String("Y2VydA=="),
                    CertificatePassword = "1234",
                },
                WorkloadProfiles =
{
new ContainerAppWorkloadProfile("My-GP-01","GeneralPurpose")
{
MinimumNodeCount = 3,
MaximumNodeCount = 12,
},new ContainerAppWorkloadProfile("My-MO-01","MemoryOptimized")
{
MinimumNodeCount = 3,
MaximumNodeCount = 6,
},new ContainerAppWorkloadProfile("My-CO-01","ComputeOptimized")
{
MinimumNodeCount = 3,
MaximumNodeCount = 6,
},new ContainerAppWorkloadProfile("My-consumption-01","Consumption")
},
                IsMtlsEnabled = true,
            };
            ArmOperation<ContainerAppManagedEnvironmentResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, environmentName, data);
            ContainerAppManagedEnvironmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerAppManagedEnvironmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
