// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataShare;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> A kusto database data set. </summary>
    public partial class KustoDatabaseDataSet : ShareDataSetData
    {
        /// <summary> Initializes a new instance of <see cref="KustoDatabaseDataSet"/>. </summary>
        /// <param name="kustoDatabaseResourceId"> Resource id of the kusto database. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kustoDatabaseResourceId"/> is null. </exception>
        public KustoDatabaseDataSet(ResourceIdentifier kustoDatabaseResourceId)
        {
            if (kustoDatabaseResourceId == null)
            {
                throw new ArgumentNullException(nameof(kustoDatabaseResourceId));
            }

            KustoDatabaseResourceId = kustoDatabaseResourceId;
            Kind = DataSetKind.KustoDatabase;
        }

        /// <summary> Initializes a new instance of <see cref="KustoDatabaseDataSet"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of data set. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="dataSetId"> Unique id for identifying a data set resource. </param>
        /// <param name="kustoDatabaseResourceId"> Resource id of the kusto database. </param>
        /// <param name="location"> Location of the kusto cluster. </param>
        /// <param name="provisioningState"> Provisioning state of the kusto database data set. </param>
        internal KustoDatabaseDataSet(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataSetKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, Guid? dataSetId, ResourceIdentifier kustoDatabaseResourceId, AzureLocation? location, DataShareProvisioningState? provisioningState) : base(id, name, resourceType, systemData, kind, serializedAdditionalRawData)
        {
            DataSetId = dataSetId;
            KustoDatabaseResourceId = kustoDatabaseResourceId;
            Location = location;
            ProvisioningState = provisioningState;
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="KustoDatabaseDataSet"/> for deserialization. </summary>
        internal KustoDatabaseDataSet()
        {
        }

        /// <summary> Unique id for identifying a data set resource. </summary>
        public Guid? DataSetId { get; }
        /// <summary> Resource id of the kusto database. </summary>
        public ResourceIdentifier KustoDatabaseResourceId { get; set; }
        /// <summary> Location of the kusto cluster. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Provisioning state of the kusto database data set. </summary>
        public DataShareProvisioningState? ProvisioningState { get; }
    }
}
