// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ContainerOrchestratorRuntime
{
    public partial class ServiceResource : IJsonModel<ServiceResourceData>
    {
        void IJsonModel<ServiceResourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ServiceResourceData>)Data).Write(writer, options);

        ServiceResourceData IJsonModel<ServiceResourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ServiceResourceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ServiceResourceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ServiceResourceData IPersistableModel<ServiceResourceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ServiceResourceData>(data, options);

        string IPersistableModel<ServiceResourceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ServiceResourceData>)Data).GetFormatFromOptions(options);
    }
}
