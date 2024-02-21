// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.CallAutomation
{
    /// <summary> Used to specify Blob container url to recording storage. </summary>
    internal partial class BlobStorageInternal
    {
        /// <summary> Initializes a new instance of <see cref="BlobStorageInternal"/>. </summary>
        /// <param name="containerUri"> Url of a container or a location within a container. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerUri"/> is null. </exception>
        public BlobStorageInternal(string containerUri)
        {
            if (containerUri == null)
            {
                throw new ArgumentNullException(nameof(containerUri));
            }

            ContainerUri = containerUri;
        }

        /// <summary> Url of a container or a location within a container. </summary>
        public string ContainerUri { get; }
    }
}
