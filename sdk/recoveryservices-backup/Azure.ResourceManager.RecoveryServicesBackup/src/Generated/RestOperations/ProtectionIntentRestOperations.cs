// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.RecoveryServicesBackup.Models;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    internal partial class ProtectionIntentRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ProtectionIntentRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ProtectionIntentRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-06-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateValidateRequest(string subscriptionId, AzureLocation location, PreValidateEnableBackupContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/Subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.RecoveryServices/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/backupPreValidateProtection", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content);
            request.Content = content0;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary>
        /// It will validate followings
        /// 1. Vault capacity
        /// 2. VM is already protected
        /// 3. Any VM related configuration passed in properties.
        /// </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="location"> Azure region to hit Api. </param>
        /// <param name="content"> Enable backup validation request on Virtual Machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<PreValidateEnableBackupResult>> ValidateAsync(string subscriptionId, AzureLocation location, PreValidateEnableBackupContent content, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var message = CreateValidateRequest(subscriptionId, location, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PreValidateEnableBackupResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PreValidateEnableBackupResult.DeserializePreValidateEnableBackupResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary>
        /// It will validate followings
        /// 1. Vault capacity
        /// 2. VM is already protected
        /// 3. Any VM related configuration passed in properties.
        /// </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="location"> Azure region to hit Api. </param>
        /// <param name="content"> Enable backup validation request on Virtual Machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<PreValidateEnableBackupResult> Validate(string subscriptionId, AzureLocation location, PreValidateEnableBackupContent content, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var message = CreateValidateRequest(subscriptionId, location, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PreValidateEnableBackupResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PreValidateEnableBackupResult.DeserializePreValidateEnableBackupResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string vaultName, string fabricName, string intentObjectName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/Subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.RecoveryServices/vaults/", false);
            uri.AppendPath(vaultName, true);
            uri.AppendPath("/backupFabrics/", false);
            uri.AppendPath(fabricName, true);
            uri.AppendPath("/backupProtectionIntent/", false);
            uri.AppendPath(intentObjectName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary>
        /// Provides the details of the protection intent up item. This is an asynchronous operation. To know the status of the operation,
        /// call the GetItemOperationResult API.
        /// </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name associated with the backed up item. </param>
        /// <param name="intentObjectName"> Backed up item name whose details are to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="intentObjectName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="intentObjectName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<BackupProtectionIntentData>> GetAsync(string subscriptionId, string resourceGroupName, string vaultName, string fabricName, string intentObjectName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }
            if (intentObjectName == null)
            {
                throw new ArgumentNullException(nameof(intentObjectName));
            }
            if (intentObjectName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(intentObjectName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, vaultName, fabricName, intentObjectName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BackupProtectionIntentData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = BackupProtectionIntentData.DeserializeBackupProtectionIntentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((BackupProtectionIntentData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary>
        /// Provides the details of the protection intent up item. This is an asynchronous operation. To know the status of the operation,
        /// call the GetItemOperationResult API.
        /// </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name associated with the backed up item. </param>
        /// <param name="intentObjectName"> Backed up item name whose details are to be fetched. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="intentObjectName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="intentObjectName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<BackupProtectionIntentData> Get(string subscriptionId, string resourceGroupName, string vaultName, string fabricName, string intentObjectName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }
            if (intentObjectName == null)
            {
                throw new ArgumentNullException(nameof(intentObjectName));
            }
            if (intentObjectName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(intentObjectName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, vaultName, fabricName, intentObjectName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BackupProtectionIntentData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = BackupProtectionIntentData.DeserializeBackupProtectionIntentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((BackupProtectionIntentData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string vaultName, string fabricName, string intentObjectName, BackupProtectionIntentData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/Subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.RecoveryServices/vaults/", false);
            uri.AppendPath(vaultName, true);
            uri.AppendPath("/backupFabrics/", false);
            uri.AppendPath(fabricName, true);
            uri.AppendPath("/backupProtectionIntent/", false);
            uri.AppendPath(intentObjectName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create Intent for Enabling backup of an item. This is a synchronous operation. </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name associated with the backup item. </param>
        /// <param name="intentObjectName"> Intent object name. </param>
        /// <param name="data"> resource backed up item. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/>, <paramref name="intentObjectName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="intentObjectName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<BackupProtectionIntentData>> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string vaultName, string fabricName, string intentObjectName, BackupProtectionIntentData data, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }
            if (intentObjectName == null)
            {
                throw new ArgumentNullException(nameof(intentObjectName));
            }
            if (intentObjectName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(intentObjectName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, vaultName, fabricName, intentObjectName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BackupProtectionIntentData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = BackupProtectionIntentData.DeserializeBackupProtectionIntentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create Intent for Enabling backup of an item. This is a synchronous operation. </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name associated with the backup item. </param>
        /// <param name="intentObjectName"> Intent object name. </param>
        /// <param name="data"> resource backed up item. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/>, <paramref name="intentObjectName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="intentObjectName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<BackupProtectionIntentData> CreateOrUpdate(string subscriptionId, string resourceGroupName, string vaultName, string fabricName, string intentObjectName, BackupProtectionIntentData data, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }
            if (intentObjectName == null)
            {
                throw new ArgumentNullException(nameof(intentObjectName));
            }
            if (intentObjectName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(intentObjectName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, vaultName, fabricName, intentObjectName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BackupProtectionIntentData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = BackupProtectionIntentData.DeserializeBackupProtectionIntentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string vaultName, string fabricName, string intentObjectName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/Subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.RecoveryServices/vaults/", false);
            uri.AppendPath(vaultName, true);
            uri.AppendPath("/backupFabrics/", false);
            uri.AppendPath(fabricName, true);
            uri.AppendPath("/backupProtectionIntent/", false);
            uri.AppendPath(intentObjectName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Used to remove intent from an item. </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name associated with the intent. </param>
        /// <param name="intentObjectName"> Intent to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="intentObjectName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="intentObjectName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string vaultName, string fabricName, string intentObjectName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }
            if (intentObjectName == null)
            {
                throw new ArgumentNullException(nameof(intentObjectName));
            }
            if (intentObjectName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(intentObjectName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, vaultName, fabricName, intentObjectName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Used to remove intent from an item. </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name associated with the intent. </param>
        /// <param name="intentObjectName"> Intent to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="intentObjectName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/>, <paramref name="fabricName"/> or <paramref name="intentObjectName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string vaultName, string fabricName, string intentObjectName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }
            if (fabricName == null)
            {
                throw new ArgumentNullException(nameof(fabricName));
            }
            if (fabricName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(fabricName));
            }
            if (intentObjectName == null)
            {
                throw new ArgumentNullException(nameof(intentObjectName));
            }
            if (intentObjectName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(intentObjectName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, vaultName, fabricName, intentObjectName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
