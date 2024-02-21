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
using Azure.ResourceManager.RecoveryServices;
using Azure.ResourceManager.RecoveryServices.Models;

namespace Azure.ResourceManager.RecoveryServices.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableRecoveryServicesSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _recoveryServicesClientDiagnostics;
        private RecoveryServicesRestOperations _recoveryServicesRestClient;
        private ClientDiagnostics _recoveryServicesVaultVaultsClientDiagnostics;
        private VaultsRestOperations _recoveryServicesVaultVaultsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableRecoveryServicesSubscriptionResource"/> class for mocking. </summary>
        protected MockableRecoveryServicesSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableRecoveryServicesSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableRecoveryServicesSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics RecoveryServicesClientDiagnostics => _recoveryServicesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.RecoveryServices", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private RecoveryServicesRestOperations RecoveryServicesRestClient => _recoveryServicesRestClient ??= new RecoveryServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics RecoveryServicesVaultVaultsClientDiagnostics => _recoveryServicesVaultVaultsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.RecoveryServices", RecoveryServicesVaultResource.ResourceType.Namespace, Diagnostics);
        private VaultsRestOperations RecoveryServicesVaultVaultsRestClient => _recoveryServicesVaultVaultsRestClient ??= new VaultsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(RecoveryServicesVaultResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// API to get details about capabilities provided by Microsoft.RecoveryServices RP
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.RecoveryServices/locations/{location}/capabilities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryServices_Capabilities</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Location of the resource. </param>
        /// <param name="input"> Contains information about Resource type and properties to get capabilities. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        public virtual async Task<Response<CapabilitiesResult>> GetRecoveryServiceCapabilitiesAsync(AzureLocation location, ResourceCapabilities input, CancellationToken cancellationToken = default)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            using var scope = RecoveryServicesClientDiagnostics.CreateScope("MockableRecoveryServicesSubscriptionResource.GetRecoveryServiceCapabilities");
            scope.Start();
            try
            {
                var response = await RecoveryServicesRestClient.CapabilitiesAsync(Id.SubscriptionId, location, input, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// API to get details about capabilities provided by Microsoft.RecoveryServices RP
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.RecoveryServices/locations/{location}/capabilities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecoveryServices_Capabilities</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Location of the resource. </param>
        /// <param name="input"> Contains information about Resource type and properties to get capabilities. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        public virtual Response<CapabilitiesResult> GetRecoveryServiceCapabilities(AzureLocation location, ResourceCapabilities input, CancellationToken cancellationToken = default)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            using var scope = RecoveryServicesClientDiagnostics.CreateScope("MockableRecoveryServicesSubscriptionResource.GetRecoveryServiceCapabilities");
            scope.Start();
            try
            {
                var response = RecoveryServicesRestClient.Capabilities(Id.SubscriptionId, location, input, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Fetches all the resources of the specified type in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.RecoveryServices/vaults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vaults_ListBySubscriptionId</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RecoveryServicesVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RecoveryServicesVaultResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RecoveryServicesVaultResource> GetRecoveryServicesVaultsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RecoveryServicesVaultVaultsRestClient.CreateListBySubscriptionIdRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RecoveryServicesVaultVaultsRestClient.CreateListBySubscriptionIdNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new RecoveryServicesVaultResource(Client, RecoveryServicesVaultData.DeserializeRecoveryServicesVaultData(e)), RecoveryServicesVaultVaultsClientDiagnostics, Pipeline, "MockableRecoveryServicesSubscriptionResource.GetRecoveryServicesVaults", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Fetches all the resources of the specified type in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.RecoveryServices/vaults</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vaults_ListBySubscriptionId</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RecoveryServicesVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RecoveryServicesVaultResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RecoveryServicesVaultResource> GetRecoveryServicesVaults(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RecoveryServicesVaultVaultsRestClient.CreateListBySubscriptionIdRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RecoveryServicesVaultVaultsRestClient.CreateListBySubscriptionIdNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new RecoveryServicesVaultResource(Client, RecoveryServicesVaultData.DeserializeRecoveryServicesVaultData(e)), RecoveryServicesVaultVaultsClientDiagnostics, Pipeline, "MockableRecoveryServicesSubscriptionResource.GetRecoveryServicesVaults", "value", "nextLink", cancellationToken);
        }
    }
}
