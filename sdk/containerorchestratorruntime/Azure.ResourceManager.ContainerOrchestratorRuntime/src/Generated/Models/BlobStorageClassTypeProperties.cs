// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerOrchestratorRuntime.Models
{
    /// <summary> The properties of Blob StorageClass. </summary>
    public partial class BlobStorageClassTypeProperties : StorageClassTypeProperties
    {
        /// <summary> Initializes a new instance of <see cref="BlobStorageClassTypeProperties"/>. </summary>
        /// <param name="azureStorageAccountName"> Azure Storage Account Name. </param>
        /// <param name="azureStorageAccountKey"> Azure Storage Account Key. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureStorageAccountName"/> or <paramref name="azureStorageAccountKey"/> is null. </exception>
        public BlobStorageClassTypeProperties(string azureStorageAccountName, string azureStorageAccountKey)
        {
            Argument.AssertNotNull(azureStorageAccountName, nameof(azureStorageAccountName));
            Argument.AssertNotNull(azureStorageAccountKey, nameof(azureStorageAccountKey));

            AzureStorageAccountName = azureStorageAccountName;
            AzureStorageAccountKey = azureStorageAccountKey;
            SCType = SCType.Blob;
        }

        /// <summary> Initializes a new instance of <see cref="BlobStorageClassTypeProperties"/>. </summary>
        /// <param name="scType"> Type of the storage class. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="azureStorageAccountName"> Azure Storage Account Name. </param>
        /// <param name="azureStorageAccountKey"> Azure Storage Account Key. </param>
        internal BlobStorageClassTypeProperties(SCType scType, IDictionary<string, BinaryData> serializedAdditionalRawData, string azureStorageAccountName, string azureStorageAccountKey) : base(scType, serializedAdditionalRawData)
        {
            AzureStorageAccountName = azureStorageAccountName;
            AzureStorageAccountKey = azureStorageAccountKey;
            SCType = scType;
        }

        /// <summary> Initializes a new instance of <see cref="BlobStorageClassTypeProperties"/> for deserialization. </summary>
        internal BlobStorageClassTypeProperties()
        {
        }

        /// <summary> Azure Storage Account Name. </summary>
        public string AzureStorageAccountName { get; set; }
        /// <summary> Azure Storage Account Key. </summary>
        public string AzureStorageAccountKey { get; set; }
    }
}
