// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.PostgreSql
{
    /// <summary>
    /// A Class representing a PostgreSqlServerAdministrator along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="PostgreSqlServerAdministratorResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetPostgreSqlServerAdministratorResource method.
    /// Otherwise you can get one from its parent resource <see cref="PostgreSqlServerResource"/> using the GetPostgreSqlServerAdministrator method.
    /// </summary>
    public partial class PostgreSqlServerAdministratorResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PostgreSqlServerAdministratorResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serverName"> The serverName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/administrators/activeDirectory";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _postgreSqlServerAdministratorServerAdministratorsClientDiagnostics;
        private readonly ServerAdministratorsRestOperations _postgreSqlServerAdministratorServerAdministratorsRestClient;
        private readonly PostgreSqlServerAdministratorData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DBforPostgreSQL/servers/administrators";

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlServerAdministratorResource"/> class for mocking. </summary>
        protected PostgreSqlServerAdministratorResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlServerAdministratorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PostgreSqlServerAdministratorResource(ArmClient client, PostgreSqlServerAdministratorData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlServerAdministratorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PostgreSqlServerAdministratorResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _postgreSqlServerAdministratorServerAdministratorsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PostgreSql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string postgreSqlServerAdministratorServerAdministratorsApiVersion);
            _postgreSqlServerAdministratorServerAdministratorsRestClient = new ServerAdministratorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, postgreSqlServerAdministratorServerAdministratorsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PostgreSqlServerAdministratorData Data
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
        /// Gets information about a AAD server administrator.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/administrators/activeDirectory</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAdministrators_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PostgreSqlServerAdministratorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PostgreSqlServerAdministratorResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _postgreSqlServerAdministratorServerAdministratorsClientDiagnostics.CreateScope("PostgreSqlServerAdministratorResource.Get");
            scope.Start();
            try
            {
                var response = await _postgreSqlServerAdministratorServerAdministratorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlServerAdministratorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a AAD server administrator.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/administrators/activeDirectory</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAdministrators_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PostgreSqlServerAdministratorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PostgreSqlServerAdministratorResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _postgreSqlServerAdministratorServerAdministratorsClientDiagnostics.CreateScope("PostgreSqlServerAdministratorResource.Get");
            scope.Start();
            try
            {
                var response = _postgreSqlServerAdministratorServerAdministratorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlServerAdministratorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes server active directory administrator.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/administrators/activeDirectory</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAdministrators_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PostgreSqlServerAdministratorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _postgreSqlServerAdministratorServerAdministratorsClientDiagnostics.CreateScope("PostgreSqlServerAdministratorResource.Delete");
            scope.Start();
            try
            {
                var response = await _postgreSqlServerAdministratorServerAdministratorsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                var operation = new PostgreSqlArmOperation(_postgreSqlServerAdministratorServerAdministratorsClientDiagnostics, Pipeline, _postgreSqlServerAdministratorServerAdministratorsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes server active directory administrator.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/administrators/activeDirectory</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAdministrators_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PostgreSqlServerAdministratorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _postgreSqlServerAdministratorServerAdministratorsClientDiagnostics.CreateScope("PostgreSqlServerAdministratorResource.Delete");
            scope.Start();
            try
            {
                var response = _postgreSqlServerAdministratorServerAdministratorsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                var operation = new PostgreSqlArmOperation(_postgreSqlServerAdministratorServerAdministratorsClientDiagnostics, Pipeline, _postgreSqlServerAdministratorServerAdministratorsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or update active directory administrator on an existing server. The update action will overwrite the existing administrator.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/administrators/activeDirectory</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAdministrators_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PostgreSqlServerAdministratorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The required parameters for creating or updating an AAD server administrator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PostgreSqlServerAdministratorResource>> CreateOrUpdateAsync(WaitUntil waitUntil, PostgreSqlServerAdministratorData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _postgreSqlServerAdministratorServerAdministratorsClientDiagnostics.CreateScope("PostgreSqlServerAdministratorResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _postgreSqlServerAdministratorServerAdministratorsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new PostgreSqlArmOperation<PostgreSqlServerAdministratorResource>(new PostgreSqlServerAdministratorOperationSource(Client), _postgreSqlServerAdministratorServerAdministratorsClientDiagnostics, Pipeline, _postgreSqlServerAdministratorServerAdministratorsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or update active directory administrator on an existing server. The update action will overwrite the existing administrator.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/administrators/activeDirectory</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAdministrators_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2017-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PostgreSqlServerAdministratorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The required parameters for creating or updating an AAD server administrator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PostgreSqlServerAdministratorResource> CreateOrUpdate(WaitUntil waitUntil, PostgreSqlServerAdministratorData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _postgreSqlServerAdministratorServerAdministratorsClientDiagnostics.CreateScope("PostgreSqlServerAdministratorResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _postgreSqlServerAdministratorServerAdministratorsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken);
                var operation = new PostgreSqlArmOperation<PostgreSqlServerAdministratorResource>(new PostgreSqlServerAdministratorOperationSource(Client), _postgreSqlServerAdministratorServerAdministratorsClientDiagnostics, Pipeline, _postgreSqlServerAdministratorServerAdministratorsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data).Request, response, OperationFinalStateVia.Location);
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
