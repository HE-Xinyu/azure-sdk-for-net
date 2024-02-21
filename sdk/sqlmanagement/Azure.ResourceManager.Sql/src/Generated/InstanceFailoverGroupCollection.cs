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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="InstanceFailoverGroupResource"/> and their operations.
    /// Each <see cref="InstanceFailoverGroupResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get an <see cref="InstanceFailoverGroupCollection"/> instance call the GetInstanceFailoverGroups method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class InstanceFailoverGroupCollection : ArmCollection, IEnumerable<InstanceFailoverGroupResource>, IAsyncEnumerable<InstanceFailoverGroupResource>
    {
        private readonly ClientDiagnostics _instanceFailoverGroupClientDiagnostics;
        private readonly InstanceFailoverGroupsRestOperations _instanceFailoverGroupRestClient;
        private readonly AzureLocation _locationName;

        /// <summary> Initializes a new instance of the <see cref="InstanceFailoverGroupCollection"/> class for mocking. </summary>
        protected InstanceFailoverGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="InstanceFailoverGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        internal InstanceFailoverGroupCollection(ArmClient client, ResourceIdentifier id, AzureLocation locationName) : base(client, id)
        {
            _locationName = locationName;
            _instanceFailoverGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", InstanceFailoverGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(InstanceFailoverGroupResource.ResourceType, out string instanceFailoverGroupApiVersion);
            _instanceFailoverGroupRestClient = new InstanceFailoverGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, instanceFailoverGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a failover group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InstanceFailoverGroups_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InstanceFailoverGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="data"> The failover group parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<InstanceFailoverGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string failoverGroupName, InstanceFailoverGroupData data, CancellationToken cancellationToken = default)
        {
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }
            if (failoverGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(failoverGroupName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _instanceFailoverGroupClientDiagnostics.CreateScope("InstanceFailoverGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _instanceFailoverGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), failoverGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<InstanceFailoverGroupResource>(new InstanceFailoverGroupOperationSource(Client), _instanceFailoverGroupClientDiagnostics, Pipeline, _instanceFailoverGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), failoverGroupName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a failover group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InstanceFailoverGroups_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InstanceFailoverGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="data"> The failover group parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<InstanceFailoverGroupResource> CreateOrUpdate(WaitUntil waitUntil, string failoverGroupName, InstanceFailoverGroupData data, CancellationToken cancellationToken = default)
        {
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }
            if (failoverGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(failoverGroupName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _instanceFailoverGroupClientDiagnostics.CreateScope("InstanceFailoverGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _instanceFailoverGroupRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), failoverGroupName, data, cancellationToken);
                var operation = new SqlArmOperation<InstanceFailoverGroupResource>(new InstanceFailoverGroupOperationSource(Client), _instanceFailoverGroupClientDiagnostics, Pipeline, _instanceFailoverGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), failoverGroupName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a failover group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InstanceFailoverGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InstanceFailoverGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public virtual async Task<Response<InstanceFailoverGroupResource>> GetAsync(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }
            if (failoverGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(failoverGroupName));
            }

            using var scope = _instanceFailoverGroupClientDiagnostics.CreateScope("InstanceFailoverGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _instanceFailoverGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), failoverGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new InstanceFailoverGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a failover group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InstanceFailoverGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InstanceFailoverGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public virtual Response<InstanceFailoverGroupResource> Get(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }
            if (failoverGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(failoverGroupName));
            }

            using var scope = _instanceFailoverGroupClientDiagnostics.CreateScope("InstanceFailoverGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _instanceFailoverGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), failoverGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new InstanceFailoverGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the failover groups in a location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InstanceFailoverGroups_ListByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InstanceFailoverGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="InstanceFailoverGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<InstanceFailoverGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _instanceFailoverGroupRestClient.CreateListByLocationRequest(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _instanceFailoverGroupRestClient.CreateListByLocationNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new InstanceFailoverGroupResource(Client, InstanceFailoverGroupData.DeserializeInstanceFailoverGroupData(e)), _instanceFailoverGroupClientDiagnostics, Pipeline, "InstanceFailoverGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the failover groups in a location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InstanceFailoverGroups_ListByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InstanceFailoverGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="InstanceFailoverGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<InstanceFailoverGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _instanceFailoverGroupRestClient.CreateListByLocationRequest(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _instanceFailoverGroupRestClient.CreateListByLocationNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new InstanceFailoverGroupResource(Client, InstanceFailoverGroupData.DeserializeInstanceFailoverGroupData(e)), _instanceFailoverGroupClientDiagnostics, Pipeline, "InstanceFailoverGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InstanceFailoverGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InstanceFailoverGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }
            if (failoverGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(failoverGroupName));
            }

            using var scope = _instanceFailoverGroupClientDiagnostics.CreateScope("InstanceFailoverGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _instanceFailoverGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), failoverGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InstanceFailoverGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InstanceFailoverGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }
            if (failoverGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(failoverGroupName));
            }

            using var scope = _instanceFailoverGroupClientDiagnostics.CreateScope("InstanceFailoverGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _instanceFailoverGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), failoverGroupName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InstanceFailoverGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InstanceFailoverGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public virtual async Task<NullableResponse<InstanceFailoverGroupResource>> GetIfExistsAsync(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }
            if (failoverGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(failoverGroupName));
            }

            using var scope = _instanceFailoverGroupClientDiagnostics.CreateScope("InstanceFailoverGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _instanceFailoverGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), failoverGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<InstanceFailoverGroupResource>(response.GetRawResponse());
                return Response.FromValue(new InstanceFailoverGroupResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/locations/{locationName}/instanceFailoverGroups/{failoverGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InstanceFailoverGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InstanceFailoverGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public virtual NullableResponse<InstanceFailoverGroupResource> GetIfExists(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            if (failoverGroupName == null)
            {
                throw new ArgumentNullException(nameof(failoverGroupName));
            }
            if (failoverGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(failoverGroupName));
            }

            using var scope = _instanceFailoverGroupClientDiagnostics.CreateScope("InstanceFailoverGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _instanceFailoverGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(_locationName), failoverGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<InstanceFailoverGroupResource>(response.GetRawResponse());
                return Response.FromValue(new InstanceFailoverGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<InstanceFailoverGroupResource> IEnumerable<InstanceFailoverGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<InstanceFailoverGroupResource> IAsyncEnumerable<InstanceFailoverGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
