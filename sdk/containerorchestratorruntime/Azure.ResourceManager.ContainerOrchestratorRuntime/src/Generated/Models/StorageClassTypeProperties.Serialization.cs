// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerOrchestratorRuntime.Models
{
    [PersistableModelProxy(typeof(UnknownStorageClassTypeProperties))]
    public partial class StorageClassTypeProperties : IUtf8JsonSerializable, IJsonModel<StorageClassTypeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageClassTypeProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StorageClassTypeProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageClassTypeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageClassTypeProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(SCType.ToString());
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        StorageClassTypeProperties IJsonModel<StorageClassTypeProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageClassTypeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageClassTypeProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageClassTypeProperties(document.RootElement, options);
        }

        internal static StorageClassTypeProperties DeserializeStorageClassTypeProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Blob": return BlobStorageClassTypeProperties.DeserializeBlobStorageClassTypeProperties(element, options);
                    case "Native": return NativeStorageClassTypeProperties.DeserializeNativeStorageClassTypeProperties(element, options);
                    case "NFS": return NfsStorageClassTypeProperties.DeserializeNfsStorageClassTypeProperties(element, options);
                    case "RWX": return RwxStorageClassTypeProperties.DeserializeRwxStorageClassTypeProperties(element, options);
                    case "SMB": return SmbStorageClassTypeProperties.DeserializeSmbStorageClassTypeProperties(element, options);
                }
            }
            return UnknownStorageClassTypeProperties.DeserializeUnknownStorageClassTypeProperties(element, options);
        }

        BinaryData IPersistableModel<StorageClassTypeProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageClassTypeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageClassTypeProperties)} does not support writing '{options.Format}' format.");
            }
        }

        StorageClassTypeProperties IPersistableModel<StorageClassTypeProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageClassTypeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageClassTypeProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageClassTypeProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageClassTypeProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
