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

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary>
    /// A class representing a collection of <see cref="ServiceBusTopicResource"/> and their operations.
    /// Each <see cref="ServiceBusTopicResource"/> in the collection will belong to the same instance of <see cref="ServiceBusNamespaceResource"/>.
    /// To get a <see cref="ServiceBusTopicCollection"/> instance call the GetServiceBusTopics method from an instance of <see cref="ServiceBusNamespaceResource"/>.
    /// </summary>
    public partial class ServiceBusTopicCollection : ArmCollection, IEnumerable<ServiceBusTopicResource>, IAsyncEnumerable<ServiceBusTopicResource>
    {
        private readonly ClientDiagnostics _serviceBusTopicTopicsClientDiagnostics;
        private readonly TopicsRestOperations _serviceBusTopicTopicsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceBusTopicCollection"/> class for mocking. </summary>
        protected ServiceBusTopicCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceBusTopicCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceBusTopicCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceBusTopicTopicsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceBus", ServiceBusTopicResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceBusTopicResource.ResourceType, out string serviceBusTopicTopicsApiVersion);
            _serviceBusTopicTopicsRestClient = new TopicsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceBusTopicTopicsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServiceBusNamespaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServiceBusNamespaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a topic in the specified namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Topics_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusTopicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="topicName"> The topic name. </param>
        /// <param name="data"> Parameters supplied to create a topic resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceBusTopicResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string topicName, ServiceBusTopicData data, CancellationToken cancellationToken = default)
        {
            if (topicName == null)
            {
                throw new ArgumentNullException(nameof(topicName));
            }
            if (topicName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(topicName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _serviceBusTopicTopicsClientDiagnostics.CreateScope("ServiceBusTopicCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceBusTopicTopicsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, topicName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceBusArmOperation<ServiceBusTopicResource>(Response.FromValue(new ServiceBusTopicResource(Client, response), response.GetRawResponse()));
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
        /// Creates a topic in the specified namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Topics_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusTopicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="topicName"> The topic name. </param>
        /// <param name="data"> Parameters supplied to create a topic resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceBusTopicResource> CreateOrUpdate(WaitUntil waitUntil, string topicName, ServiceBusTopicData data, CancellationToken cancellationToken = default)
        {
            if (topicName == null)
            {
                throw new ArgumentNullException(nameof(topicName));
            }
            if (topicName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(topicName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _serviceBusTopicTopicsClientDiagnostics.CreateScope("ServiceBusTopicCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceBusTopicTopicsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, topicName, data, cancellationToken);
                var operation = new ServiceBusArmOperation<ServiceBusTopicResource>(Response.FromValue(new ServiceBusTopicResource(Client, response), response.GetRawResponse()));
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
        /// Returns a description for the specified topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Topics_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusTopicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topicName"> The topic name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicName"/> is null. </exception>
        public virtual async Task<Response<ServiceBusTopicResource>> GetAsync(string topicName, CancellationToken cancellationToken = default)
        {
            if (topicName == null)
            {
                throw new ArgumentNullException(nameof(topicName));
            }
            if (topicName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(topicName));
            }

            using var scope = _serviceBusTopicTopicsClientDiagnostics.CreateScope("ServiceBusTopicCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceBusTopicTopicsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, topicName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceBusTopicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a description for the specified topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Topics_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusTopicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topicName"> The topic name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicName"/> is null. </exception>
        public virtual Response<ServiceBusTopicResource> Get(string topicName, CancellationToken cancellationToken = default)
        {
            if (topicName == null)
            {
                throw new ArgumentNullException(nameof(topicName));
            }
            if (topicName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(topicName));
            }

            using var scope = _serviceBusTopicTopicsClientDiagnostics.CreateScope("ServiceBusTopicCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceBusTopicTopicsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, topicName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceBusTopicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the topics in a namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Topics_ListByNamespace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusTopicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceBusTopicResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceBusTopicResource> GetAllAsync(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceBusTopicTopicsRestClient.CreateListByNamespaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceBusTopicTopicsRestClient.CreateListByNamespaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ServiceBusTopicResource(Client, ServiceBusTopicData.DeserializeServiceBusTopicData(e)), _serviceBusTopicTopicsClientDiagnostics, Pipeline, "ServiceBusTopicCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the topics in a namespace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Topics_ListByNamespace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusTopicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceBusTopicResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceBusTopicResource> GetAll(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceBusTopicTopicsRestClient.CreateListByNamespaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceBusTopicTopicsRestClient.CreateListByNamespaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ServiceBusTopicResource(Client, ServiceBusTopicData.DeserializeServiceBusTopicData(e)), _serviceBusTopicTopicsClientDiagnostics, Pipeline, "ServiceBusTopicCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Topics_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusTopicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topicName"> The topic name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string topicName, CancellationToken cancellationToken = default)
        {
            if (topicName == null)
            {
                throw new ArgumentNullException(nameof(topicName));
            }
            if (topicName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(topicName));
            }

            using var scope = _serviceBusTopicTopicsClientDiagnostics.CreateScope("ServiceBusTopicCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceBusTopicTopicsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, topicName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Topics_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusTopicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topicName"> The topic name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicName"/> is null. </exception>
        public virtual Response<bool> Exists(string topicName, CancellationToken cancellationToken = default)
        {
            if (topicName == null)
            {
                throw new ArgumentNullException(nameof(topicName));
            }
            if (topicName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(topicName));
            }

            using var scope = _serviceBusTopicTopicsClientDiagnostics.CreateScope("ServiceBusTopicCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceBusTopicTopicsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, topicName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Topics_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusTopicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topicName"> The topic name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicName"/> is null. </exception>
        public virtual async Task<NullableResponse<ServiceBusTopicResource>> GetIfExistsAsync(string topicName, CancellationToken cancellationToken = default)
        {
            if (topicName == null)
            {
                throw new ArgumentNullException(nameof(topicName));
            }
            if (topicName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(topicName));
            }

            using var scope = _serviceBusTopicTopicsClientDiagnostics.CreateScope("ServiceBusTopicCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serviceBusTopicTopicsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, topicName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ServiceBusTopicResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceBusTopicResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/topics/{topicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Topics_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceBusTopicResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topicName"> The topic name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicName"/> is null. </exception>
        public virtual NullableResponse<ServiceBusTopicResource> GetIfExists(string topicName, CancellationToken cancellationToken = default)
        {
            if (topicName == null)
            {
                throw new ArgumentNullException(nameof(topicName));
            }
            if (topicName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(topicName));
            }

            using var scope = _serviceBusTopicTopicsClientDiagnostics.CreateScope("ServiceBusTopicCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serviceBusTopicTopicsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, topicName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ServiceBusTopicResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceBusTopicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceBusTopicResource> IEnumerable<ServiceBusTopicResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceBusTopicResource> IAsyncEnumerable<ServiceBusTopicResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
