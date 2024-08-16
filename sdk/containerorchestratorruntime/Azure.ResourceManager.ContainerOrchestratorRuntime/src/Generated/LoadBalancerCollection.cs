// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.ContainerOrchestratorRuntime
{
    /// <summary>
    /// A class representing a collection of <see cref="LoadBalancerResource"/> and their operations.
    /// Each <see cref="LoadBalancerResource"/> in the collection will belong to the same instance of <see cref="ArmResource"/>.
    /// To get a <see cref="LoadBalancerCollection"/> instance call the GetLoadBalancers method from an instance of <see cref="ArmResource"/>.
    /// </summary>
    public partial class LoadBalancerCollection : ArmCollection, IEnumerable<LoadBalancerResource>, IAsyncEnumerable<LoadBalancerResource>
    {
        private readonly ClientDiagnostics _loadBalancerClientDiagnostics;
        private readonly LoadBalancersRestOperations _loadBalancerRestClient;

        /// <summary> Initializes a new instance of the <see cref="LoadBalancerCollection"/> class for mocking. </summary>
        protected LoadBalancerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LoadBalancerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LoadBalancerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _loadBalancerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerOrchestratorRuntime", LoadBalancerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LoadBalancerResource.ResourceType, out string loadBalancerApiVersion);
            _loadBalancerRestClient = new LoadBalancersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, loadBalancerApiVersion);
        }

        /// <summary>
        /// Create a LoadBalancer
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.KubernetesRuntime/loadBalancers/{loadBalancerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadBalancerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="loadBalancerName"> The name of the LoadBalancer. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancerName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<LoadBalancerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string loadBalancerName, LoadBalancerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadBalancerName, nameof(loadBalancerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _loadBalancerRestClient.CreateOrUpdateAsync(Id, loadBalancerName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerOrchestratorRuntimeArmOperation<LoadBalancerResource>(new LoadBalancerOperationSource(Client), _loadBalancerClientDiagnostics, Pipeline, _loadBalancerRestClient.CreateCreateOrUpdateRequest(Id, loadBalancerName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a LoadBalancer
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.KubernetesRuntime/loadBalancers/{loadBalancerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadBalancerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="loadBalancerName"> The name of the LoadBalancer. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancerName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<LoadBalancerResource> CreateOrUpdate(WaitUntil waitUntil, string loadBalancerName, LoadBalancerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadBalancerName, nameof(loadBalancerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _loadBalancerRestClient.CreateOrUpdate(Id, loadBalancerName, data, cancellationToken);
                var operation = new ContainerOrchestratorRuntimeArmOperation<LoadBalancerResource>(new LoadBalancerOperationSource(Client), _loadBalancerClientDiagnostics, Pipeline, _loadBalancerRestClient.CreateCreateOrUpdateRequest(Id, loadBalancerName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a LoadBalancer
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.KubernetesRuntime/loadBalancers/{loadBalancerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadBalancerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="loadBalancerName"> The name of the LoadBalancer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancerName"/> is null. </exception>
        public virtual async Task<Response<LoadBalancerResource>> GetAsync(string loadBalancerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadBalancerName, nameof(loadBalancerName));

            using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancerCollection.Get");
            scope.Start();
            try
            {
                var response = await _loadBalancerRestClient.GetAsync(Id, loadBalancerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LoadBalancerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a LoadBalancer
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.KubernetesRuntime/loadBalancers/{loadBalancerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadBalancerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="loadBalancerName"> The name of the LoadBalancer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancerName"/> is null. </exception>
        public virtual Response<LoadBalancerResource> Get(string loadBalancerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadBalancerName, nameof(loadBalancerName));

            using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancerCollection.Get");
            scope.Start();
            try
            {
                var response = _loadBalancerRestClient.Get(Id, loadBalancerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LoadBalancerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List LoadBalancer resources by parent
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.KubernetesRuntime/loadBalancers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancers_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadBalancerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LoadBalancerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LoadBalancerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _loadBalancerRestClient.CreateListRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _loadBalancerRestClient.CreateListNextPageRequest(nextLink, Id);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new LoadBalancerResource(Client, LoadBalancerData.DeserializeLoadBalancerData(e)), _loadBalancerClientDiagnostics, Pipeline, "LoadBalancerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List LoadBalancer resources by parent
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.KubernetesRuntime/loadBalancers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancers_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadBalancerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LoadBalancerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LoadBalancerResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _loadBalancerRestClient.CreateListRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _loadBalancerRestClient.CreateListNextPageRequest(nextLink, Id);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new LoadBalancerResource(Client, LoadBalancerData.DeserializeLoadBalancerData(e)), _loadBalancerClientDiagnostics, Pipeline, "LoadBalancerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.KubernetesRuntime/loadBalancers/{loadBalancerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadBalancerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="loadBalancerName"> The name of the LoadBalancer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string loadBalancerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadBalancerName, nameof(loadBalancerName));

            using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _loadBalancerRestClient.GetAsync(Id, loadBalancerName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{resourceUri}/providers/Microsoft.KubernetesRuntime/loadBalancers/{loadBalancerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadBalancerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="loadBalancerName"> The name of the LoadBalancer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancerName"/> is null. </exception>
        public virtual Response<bool> Exists(string loadBalancerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadBalancerName, nameof(loadBalancerName));

            using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancerCollection.Exists");
            scope.Start();
            try
            {
                var response = _loadBalancerRestClient.Get(Id, loadBalancerName, cancellationToken: cancellationToken);
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
        /// <description>/{resourceUri}/providers/Microsoft.KubernetesRuntime/loadBalancers/{loadBalancerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadBalancerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="loadBalancerName"> The name of the LoadBalancer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancerName"/> is null. </exception>
        public virtual async Task<NullableResponse<LoadBalancerResource>> GetIfExistsAsync(string loadBalancerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadBalancerName, nameof(loadBalancerName));

            using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _loadBalancerRestClient.GetAsync(Id, loadBalancerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<LoadBalancerResource>(response.GetRawResponse());
                return Response.FromValue(new LoadBalancerResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/{resourceUri}/providers/Microsoft.KubernetesRuntime/loadBalancers/{loadBalancerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadBalancerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="loadBalancerName"> The name of the LoadBalancer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancerName"/> is null. </exception>
        public virtual NullableResponse<LoadBalancerResource> GetIfExists(string loadBalancerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadBalancerName, nameof(loadBalancerName));

            using var scope = _loadBalancerClientDiagnostics.CreateScope("LoadBalancerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _loadBalancerRestClient.Get(Id, loadBalancerName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<LoadBalancerResource>(response.GetRawResponse());
                return Response.FromValue(new LoadBalancerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LoadBalancerResource> IEnumerable<LoadBalancerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LoadBalancerResource> IAsyncEnumerable<LoadBalancerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
