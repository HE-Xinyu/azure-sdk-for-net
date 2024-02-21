// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="MachineLearningRegistryEnvironmentVersionResource"/> and their operations.
    /// Each <see cref="MachineLearningRegistryEnvironmentVersionResource"/> in the collection will belong to the same instance of <see cref="MachineLearningRegistryEnvironmentContainerResource"/>.
    /// To get a <see cref="MachineLearningRegistryEnvironmentVersionCollection"/> instance call the GetMachineLearningRegistryEnvironmentVersions method from an instance of <see cref="MachineLearningRegistryEnvironmentContainerResource"/>.
    /// </summary>
    public partial class MachineLearningRegistryEnvironmentVersionCollection : ArmCollection, IEnumerable<MachineLearningRegistryEnvironmentVersionResource>, IAsyncEnumerable<MachineLearningRegistryEnvironmentVersionResource>
    {
        private readonly ClientDiagnostics _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsClientDiagnostics;
        private readonly RegistryEnvironmentVersionsRestOperations _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MachineLearningRegistryEnvironmentVersionCollection"/> class for mocking. </summary>
        protected MachineLearningRegistryEnvironmentVersionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningRegistryEnvironmentVersionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MachineLearningRegistryEnvironmentVersionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", MachineLearningRegistryEnvironmentVersionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MachineLearningRegistryEnvironmentVersionResource.ResourceType, out string machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsApiVersion);
            _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsRestClient = new RegistryEnvironmentVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MachineLearningRegistryEnvironmentContainerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MachineLearningRegistryEnvironmentContainerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/environments/{environmentName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryEnvironmentVersions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryEnvironmentVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="version"> Version identifier. </param>
        /// <param name="data"> Version entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineLearningRegistryEnvironmentVersionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string version, MachineLearningEnvironmentVersionData data, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (version.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(version));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsClientDiagnostics.CreateScope("MachineLearningRegistryEnvironmentVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<MachineLearningRegistryEnvironmentVersionResource>(new MachineLearningRegistryEnvironmentVersionOperationSource(Client), _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsClientDiagnostics, Pipeline, _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data).Request, response, OperationFinalStateVia.OriginalUri);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/environments/{environmentName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryEnvironmentVersions_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryEnvironmentVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="version"> Version identifier. </param>
        /// <param name="data"> Version entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MachineLearningRegistryEnvironmentVersionResource> CreateOrUpdate(WaitUntil waitUntil, string version, MachineLearningEnvironmentVersionData data, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (version.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(version));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsClientDiagnostics.CreateScope("MachineLearningRegistryEnvironmentVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data, cancellationToken);
                var operation = new MachineLearningArmOperation<MachineLearningRegistryEnvironmentVersionResource>(new MachineLearningRegistryEnvironmentVersionOperationSource(Client), _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsClientDiagnostics, Pipeline, _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, data).Request, response, OperationFinalStateVia.OriginalUri);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/environments/{environmentName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryEnvironmentVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryEnvironmentVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<Response<MachineLearningRegistryEnvironmentVersionResource>> GetAsync(string version, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (version.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(version));
            }

            using var scope = _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsClientDiagnostics.CreateScope("MachineLearningRegistryEnvironmentVersionCollection.Get");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningRegistryEnvironmentVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/environments/{environmentName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryEnvironmentVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryEnvironmentVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual Response<MachineLearningRegistryEnvironmentVersionResource> Get(string version, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (version.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(version));
            }

            using var scope = _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsClientDiagnostics.CreateScope("MachineLearningRegistryEnvironmentVersionCollection.Get");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningRegistryEnvironmentVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/environments/{environmentName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryEnvironmentVersions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryEnvironmentVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="orderBy"> Ordering of list. </param>
        /// <param name="top"> Maximum number of records to return. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="listViewType"> View type for including/excluding (for example) archived entities. </param>
        /// <param name="stage"> Stage for including/excluding (for example) archived entities. Takes priority over listViewType. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineLearningRegistryEnvironmentVersionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearningRegistryEnvironmentVersionResource> GetAllAsync(string orderBy = null, int? top = null, string skip = null, MachineLearningListViewType? listViewType = null, string stage = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, orderBy, top, skip, listViewType, stage);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, orderBy, top, skip, listViewType, stage);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MachineLearningRegistryEnvironmentVersionResource(Client, MachineLearningEnvironmentVersionData.DeserializeMachineLearningEnvironmentVersionData(e)), _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsClientDiagnostics, Pipeline, "MachineLearningRegistryEnvironmentVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/environments/{environmentName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryEnvironmentVersions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryEnvironmentVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="orderBy"> Ordering of list. </param>
        /// <param name="top"> Maximum number of records to return. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="listViewType"> View type for including/excluding (for example) archived entities. </param>
        /// <param name="stage"> Stage for including/excluding (for example) archived entities. Takes priority over listViewType. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineLearningRegistryEnvironmentVersionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearningRegistryEnvironmentVersionResource> GetAll(string orderBy = null, int? top = null, string skip = null, MachineLearningListViewType? listViewType = null, string stage = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, orderBy, top, skip, listViewType, stage);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, orderBy, top, skip, listViewType, stage);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MachineLearningRegistryEnvironmentVersionResource(Client, MachineLearningEnvironmentVersionData.DeserializeMachineLearningEnvironmentVersionData(e)), _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsClientDiagnostics, Pipeline, "MachineLearningRegistryEnvironmentVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/environments/{environmentName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryEnvironmentVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryEnvironmentVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string version, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (version.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(version));
            }

            using var scope = _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsClientDiagnostics.CreateScope("MachineLearningRegistryEnvironmentVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/environments/{environmentName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryEnvironmentVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryEnvironmentVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual Response<bool> Exists(string version, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (version.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(version));
            }

            using var scope = _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsClientDiagnostics.CreateScope("MachineLearningRegistryEnvironmentVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/environments/{environmentName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryEnvironmentVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryEnvironmentVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<NullableResponse<MachineLearningRegistryEnvironmentVersionResource>> GetIfExistsAsync(string version, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (version.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(version));
            }

            using var scope = _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsClientDiagnostics.CreateScope("MachineLearningRegistryEnvironmentVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningRegistryEnvironmentVersionResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningRegistryEnvironmentVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/registries/{registryName}/environments/{environmentName}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistryEnvironmentVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningRegistryEnvironmentVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual NullableResponse<MachineLearningRegistryEnvironmentVersionResource> GetIfExists(string version, CancellationToken cancellationToken = default)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (version.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(version));
            }

            using var scope = _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsClientDiagnostics.CreateScope("MachineLearningRegistryEnvironmentVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _machineLearningRegistryEnvironmentVersionRegistryEnvironmentVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, version, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningRegistryEnvironmentVersionResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningRegistryEnvironmentVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MachineLearningRegistryEnvironmentVersionResource> IEnumerable<MachineLearningRegistryEnvironmentVersionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MachineLearningRegistryEnvironmentVersionResource> IAsyncEnumerable<MachineLearningRegistryEnvironmentVersionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
