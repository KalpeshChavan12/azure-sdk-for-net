// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The storage account linked service. </summary>
    public partial class AzureStorageLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of AzureStorageLinkedService. </summary>
        public AzureStorageLinkedService()
        {
            LinkedServiceType = "AzureStorage";
        }

        /// <summary> Initializes a new instance of AzureStorageLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="connectionString"> The connection string. It is mutually exclusive with sasUri property. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="accountKey"> The Azure key vault secret reference of accountKey in connection string. </param>
        /// <param name="sasUri"> SAS URI of the Azure Storage resource. It is mutually exclusive with connectionString property. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="sasToken"> The Azure key vault secret reference of sasToken in sas uri. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal AzureStorageLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> connectionString, DataFactoryKeyVaultSecretReference accountKey, DataFactoryElement<string> sasUri, DataFactoryKeyVaultSecretReference sasToken, string encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            ConnectionString = connectionString;
            AccountKey = accountKey;
            SasUri = sasUri;
            SasToken = sasToken;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "AzureStorage";
        }

        /// <summary> The connection string. It is mutually exclusive with sasUri property. Type: string, SecureString or AzureKeyVaultSecretReference. </summary>
        public DataFactoryElement<string> ConnectionString { get; set; }
        /// <summary> The Azure key vault secret reference of accountKey in connection string. </summary>
        public DataFactoryKeyVaultSecretReference AccountKey { get; set; }
        /// <summary> SAS URI of the Azure Storage resource. It is mutually exclusive with connectionString property. Type: string, SecureString or AzureKeyVaultSecretReference. </summary>
        public DataFactoryElement<string> SasUri { get; set; }
        /// <summary> The Azure key vault secret reference of sasToken in sas uri. </summary>
        public DataFactoryKeyVaultSecretReference SasToken { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
