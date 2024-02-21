// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.MixedReality.RemoteRendering
{
    /// <summary> Request to start a conversion. </summary>
    internal partial class CreateConversionSettings
    {
        /// <summary> Initializes a new instance of <see cref="CreateConversionSettings"/>. </summary>
        /// <param name="settings"> Conversion settings describe the origin of input files and destination of output files. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="settings"/> is null. </exception>
        public CreateConversionSettings(AssetConversionOptions settings)
        {
            if (settings == null)
            {
                throw new ArgumentNullException(nameof(settings));
            }

            Settings = settings;
        }

        /// <summary> Conversion settings describe the origin of input files and destination of output files. </summary>
        public AssetConversionOptions Settings { get; }
    }
}
