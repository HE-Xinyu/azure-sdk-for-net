// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ServiceFabric;
using Azure.ResourceManager.ServiceFabric.Models;

namespace Azure.ResourceManager.ServiceFabric.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableServiceFabricSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _serviceFabricClusterClustersClientDiagnostics;
        private ClustersRestOperations _serviceFabricClusterClustersRestClient;
        private ClientDiagnostics _clusterVersionsClientDiagnostics;
        private ClusterVersionsRestOperations _clusterVersionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableServiceFabricSubscriptionResource"/> class for mocking. </summary>
        protected MockableServiceFabricSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableServiceFabricSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableServiceFabricSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ServiceFabricClusterClustersClientDiagnostics => _serviceFabricClusterClustersClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ServiceFabric", ServiceFabricClusterResource.ResourceType.Namespace, Diagnostics);
        private ClustersRestOperations ServiceFabricClusterClustersRestClient => _serviceFabricClusterClustersRestClient ??= new ClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ServiceFabricClusterResource.ResourceType));
        private ClientDiagnostics ClusterVersionsClientDiagnostics => _clusterVersionsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ServiceFabric", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ClusterVersionsRestOperations ClusterVersionsRestClient => _clusterVersionsRestClient ??= new ClusterVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ServiceFabricVmSizeResources in the SubscriptionResource. </summary>
        /// <param name="location"> The location parameter. </param>
        /// <returns> An object representing collection of ServiceFabricVmSizeResources and their operations over a ServiceFabricVmSizeResource. </returns>
        public virtual ServiceFabricVmSizeResourceCollection GetServiceFabricVmSizeResources(AzureLocation location)
        {
            return new ServiceFabricVmSizeResourceCollection(Client, Id, location);
        }

        /// <summary>
        /// Get unsupported vm size for Service Fabric Clusters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/unsupportedVmSizes/{vmSize}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UnsupportedVmSizes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceFabricVmSizeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location parameter. </param>
        /// <param name="vmSize"> VM Size name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmSize"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="vmSize"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ServiceFabricVmSizeResource>> GetServiceFabricVmSizeResourceAsync(AzureLocation location, string vmSize, CancellationToken cancellationToken = default)
        {
            return await GetServiceFabricVmSizeResources(location).GetAsync(vmSize, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get unsupported vm size for Service Fabric Clusters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/unsupportedVmSizes/{vmSize}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UnsupportedVmSizes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceFabricVmSizeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location parameter. </param>
        /// <param name="vmSize"> VM Size name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmSize"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="vmSize"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ServiceFabricVmSizeResource> GetServiceFabricVmSizeResource(AzureLocation location, string vmSize, CancellationToken cancellationToken = default)
        {
            return GetServiceFabricVmSizeResources(location).Get(vmSize, cancellationToken);
        }

        /// <summary>
        /// Gets all Service Fabric cluster resources created or in the process of being created in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/clusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceFabricClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceFabricClusterResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceFabricClusterResource> GetServiceFabricClustersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ServiceFabricClusterClustersRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ServiceFabricClusterClustersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ServiceFabricClusterResource(Client, ServiceFabricClusterData.DeserializeServiceFabricClusterData(e)), ServiceFabricClusterClustersClientDiagnostics, Pipeline, "MockableServiceFabricSubscriptionResource.GetServiceFabricClusters", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all Service Fabric cluster resources created or in the process of being created in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/clusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceFabricClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceFabricClusterResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceFabricClusterResource> GetServiceFabricClusters(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ServiceFabricClusterClustersRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ServiceFabricClusterClustersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ServiceFabricClusterResource(Client, ServiceFabricClusterData.DeserializeServiceFabricClusterData(e)), ServiceFabricClusterClustersClientDiagnostics, Pipeline, "MockableServiceFabricSubscriptionResource.GetServiceFabricClusters", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets information about an available Service Fabric cluster code version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/clusterVersions/{clusterVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location parameter. </param>
        /// <param name="clusterVersion"> The cluster code version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterVersion"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterVersion"/> is null. </exception>
        /// <returns> An async collection of <see cref="ClusterCodeVersionsResult"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ClusterCodeVersionsResult> GetClusterVersionsAsync(AzureLocation location, string clusterVersion, CancellationToken cancellationToken = default)
        {
            if (clusterVersion == null)
            {
                throw new ArgumentNullException(nameof(clusterVersion));
            }
            if (clusterVersion.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(clusterVersion));
            }

            HttpMessage FirstPageRequest(int? pageSizeHint) => ClusterVersionsRestClient.CreateGetRequest(Id.SubscriptionId, location, clusterVersion);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => ClusterCodeVersionsResult.DeserializeClusterCodeVersionsResult(e), ClusterVersionsClientDiagnostics, Pipeline, "MockableServiceFabricSubscriptionResource.GetClusterVersions", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets information about an available Service Fabric cluster code version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/clusterVersions/{clusterVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location parameter. </param>
        /// <param name="clusterVersion"> The cluster code version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterVersion"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterVersion"/> is null. </exception>
        /// <returns> A collection of <see cref="ClusterCodeVersionsResult"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ClusterCodeVersionsResult> GetClusterVersions(AzureLocation location, string clusterVersion, CancellationToken cancellationToken = default)
        {
            if (clusterVersion == null)
            {
                throw new ArgumentNullException(nameof(clusterVersion));
            }
            if (clusterVersion.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(clusterVersion));
            }

            HttpMessage FirstPageRequest(int? pageSizeHint) => ClusterVersionsRestClient.CreateGetRequest(Id.SubscriptionId, location, clusterVersion);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => ClusterCodeVersionsResult.DeserializeClusterCodeVersionsResult(e), ClusterVersionsClientDiagnostics, Pipeline, "MockableServiceFabricSubscriptionResource.GetClusterVersions", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets information about an available Service Fabric cluster code version by environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/environments/{environment}/clusterVersions/{clusterVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterVersions_GetByEnvironment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location parameter. </param>
        /// <param name="environment"> The operating system of the cluster. The default means all. </param>
        /// <param name="clusterVersion"> The cluster code version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterVersion"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterVersion"/> is null. </exception>
        /// <returns> An async collection of <see cref="ClusterCodeVersionsResult"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ClusterCodeVersionsResult> GetClusterVersionsByEnvironmentAsync(AzureLocation location, ClusterVersionsEnvironment environment, string clusterVersion, CancellationToken cancellationToken = default)
        {
            if (clusterVersion == null)
            {
                throw new ArgumentNullException(nameof(clusterVersion));
            }
            if (clusterVersion.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(clusterVersion));
            }

            HttpMessage FirstPageRequest(int? pageSizeHint) => ClusterVersionsRestClient.CreateGetByEnvironmentRequest(Id.SubscriptionId, location, environment, clusterVersion);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => ClusterCodeVersionsResult.DeserializeClusterCodeVersionsResult(e), ClusterVersionsClientDiagnostics, Pipeline, "MockableServiceFabricSubscriptionResource.GetClusterVersionsByEnvironment", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets information about an available Service Fabric cluster code version by environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/environments/{environment}/clusterVersions/{clusterVersion}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterVersions_GetByEnvironment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location parameter. </param>
        /// <param name="environment"> The operating system of the cluster. The default means all. </param>
        /// <param name="clusterVersion"> The cluster code version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterVersion"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterVersion"/> is null. </exception>
        /// <returns> A collection of <see cref="ClusterCodeVersionsResult"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ClusterCodeVersionsResult> GetClusterVersionsByEnvironment(AzureLocation location, ClusterVersionsEnvironment environment, string clusterVersion, CancellationToken cancellationToken = default)
        {
            if (clusterVersion == null)
            {
                throw new ArgumentNullException(nameof(clusterVersion));
            }
            if (clusterVersion.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(clusterVersion));
            }

            HttpMessage FirstPageRequest(int? pageSizeHint) => ClusterVersionsRestClient.CreateGetByEnvironmentRequest(Id.SubscriptionId, location, environment, clusterVersion);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => ClusterCodeVersionsResult.DeserializeClusterCodeVersionsResult(e), ClusterVersionsClientDiagnostics, Pipeline, "MockableServiceFabricSubscriptionResource.GetClusterVersionsByEnvironment", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets all available code versions for Service Fabric cluster resources by location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/clusterVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterVersions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ClusterCodeVersionsResult"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ClusterCodeVersionsResult> GetClusterVersionsAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ClusterVersionsRestClient.CreateListRequest(Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => ClusterCodeVersionsResult.DeserializeClusterCodeVersionsResult(e), ClusterVersionsClientDiagnostics, Pipeline, "MockableServiceFabricSubscriptionResource.GetClusterVersions", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets all available code versions for Service Fabric cluster resources by location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/clusterVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterVersions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ClusterCodeVersionsResult"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ClusterCodeVersionsResult> GetClusterVersions(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ClusterVersionsRestClient.CreateListRequest(Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => ClusterCodeVersionsResult.DeserializeClusterCodeVersionsResult(e), ClusterVersionsClientDiagnostics, Pipeline, "MockableServiceFabricSubscriptionResource.GetClusterVersions", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets all available code versions for Service Fabric cluster resources by environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/environments/{environment}/clusterVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterVersions_ListByEnvironment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location parameter. </param>
        /// <param name="environment"> The operating system of the cluster. The default means all. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ClusterCodeVersionsResult"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ClusterCodeVersionsResult> GetClusterVersionsByEnvironmentAsync(AzureLocation location, ClusterVersionsEnvironment environment, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ClusterVersionsRestClient.CreateListByEnvironmentRequest(Id.SubscriptionId, location, environment);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => ClusterCodeVersionsResult.DeserializeClusterCodeVersionsResult(e), ClusterVersionsClientDiagnostics, Pipeline, "MockableServiceFabricSubscriptionResource.GetClusterVersionsByEnvironment", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets all available code versions for Service Fabric cluster resources by environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ServiceFabric/locations/{location}/environments/{environment}/clusterVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterVersions_ListByEnvironment</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location parameter. </param>
        /// <param name="environment"> The operating system of the cluster. The default means all. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ClusterCodeVersionsResult"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ClusterCodeVersionsResult> GetClusterVersionsByEnvironment(AzureLocation location, ClusterVersionsEnvironment environment, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ClusterVersionsRestClient.CreateListByEnvironmentRequest(Id.SubscriptionId, location, environment);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => ClusterCodeVersionsResult.DeserializeClusterCodeVersionsResult(e), ClusterVersionsClientDiagnostics, Pipeline, "MockableServiceFabricSubscriptionResource.GetClusterVersionsByEnvironment", "value", null, cancellationToken);
        }
    }
}
