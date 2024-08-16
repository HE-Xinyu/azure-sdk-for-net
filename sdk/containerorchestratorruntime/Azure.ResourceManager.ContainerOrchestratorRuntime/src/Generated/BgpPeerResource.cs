// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.ContainerOrchestratorRuntime
{
    /// <summary>
    /// A Class representing a BgpPeer along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="BgpPeerResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetBgpPeerResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetBgpPeer method.
    /// </summary>
    public partial class BgpPeerResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="BgpPeerResource"/> instance. </summary>
        /// <param name="resourceUri"> The resourceUri. </param>
        /// <param name="bgpPeerName"> The bgpPeerName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string resourceUri, string bgpPeerName)
        {
            var resourceId = $"{resourceUri}/providers/Microsoft.KubernetesRuntime/bgpPeers/{bgpPeerName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _bgpPeerClientDiagnostics;
        private readonly BgpPeersRestOperations _bgpPeerRestClient;
        private readonly BgpPeerData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.KubernetesRuntime/bgpPeers";

        /// <summary> Initializes a new instance of the <see cref="BgpPeerResource"/> class for mocking. </summary>
        protected BgpPeerResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BgpPeerResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BgpPeerResource(ArmClient client, BgpPeerData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BgpPeerResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BgpPeerResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _bgpPeerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerOrchestratorRuntime", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string bgpPeerApiVersion);
            _bgpPeerRestClient = new BgpPeersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, bgpPeerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual BgpPeerData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a BgpPeer
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.KubernetesRuntime/bgpPeers/{bgpPeerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BgpPeers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BgpPeerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BgpPeerResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _bgpPeerClientDiagnostics.CreateScope("BgpPeerResource.Get");
            scope.Start();
            try
            {
                var response = await _bgpPeerRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BgpPeerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a BgpPeer
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.KubernetesRuntime/bgpPeers/{bgpPeerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BgpPeers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BgpPeerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BgpPeerResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _bgpPeerClientDiagnostics.CreateScope("BgpPeerResource.Get");
            scope.Start();
            try
            {
                var response = _bgpPeerRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BgpPeerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a BgpPeer
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.KubernetesRuntime/bgpPeers/{bgpPeerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BgpPeers_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BgpPeerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _bgpPeerClientDiagnostics.CreateScope("BgpPeerResource.Delete");
            scope.Start();
            try
            {
                var response = await _bgpPeerRestClient.DeleteAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                var uri = _bgpPeerRestClient.CreateDeleteRequestUri(Id.Parent, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ContainerOrchestratorRuntimeArmOperation(response, rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a BgpPeer
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.KubernetesRuntime/bgpPeers/{bgpPeerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BgpPeers_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BgpPeerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _bgpPeerClientDiagnostics.CreateScope("BgpPeerResource.Delete");
            scope.Start();
            try
            {
                var response = _bgpPeerRestClient.Delete(Id.Parent, Id.Name, cancellationToken);
                var uri = _bgpPeerRestClient.CreateDeleteRequestUri(Id.Parent, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ContainerOrchestratorRuntimeArmOperation(response, rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a BgpPeer
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.KubernetesRuntime/bgpPeers/{bgpPeerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BgpPeers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BgpPeerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BgpPeerResource>> UpdateAsync(WaitUntil waitUntil, BgpPeerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _bgpPeerClientDiagnostics.CreateScope("BgpPeerResource.Update");
            scope.Start();
            try
            {
                var response = await _bgpPeerRestClient.CreateOrUpdateAsync(Id.Parent, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerOrchestratorRuntimeArmOperation<BgpPeerResource>(new BgpPeerOperationSource(Client), _bgpPeerClientDiagnostics, Pipeline, _bgpPeerRestClient.CreateCreateOrUpdateRequest(Id.Parent, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a BgpPeer
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.KubernetesRuntime/bgpPeers/{bgpPeerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BgpPeers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BgpPeerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BgpPeerResource> Update(WaitUntil waitUntil, BgpPeerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _bgpPeerClientDiagnostics.CreateScope("BgpPeerResource.Update");
            scope.Start();
            try
            {
                var response = _bgpPeerRestClient.CreateOrUpdate(Id.Parent, Id.Name, data, cancellationToken);
                var operation = new ContainerOrchestratorRuntimeArmOperation<BgpPeerResource>(new BgpPeerOperationSource(Client), _bgpPeerClientDiagnostics, Pipeline, _bgpPeerRestClient.CreateCreateOrUpdateRequest(Id.Parent, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
    }
}
