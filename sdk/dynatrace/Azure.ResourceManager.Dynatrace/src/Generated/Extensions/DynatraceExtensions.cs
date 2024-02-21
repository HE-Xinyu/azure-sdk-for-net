// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Dynatrace.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Dynatrace
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Dynatrace. </summary>
    public static partial class DynatraceExtensions
    {
        private static MockableDynatraceArmClient GetMockableDynatraceArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableDynatraceArmClient(client0));
        }

        private static MockableDynatraceResourceGroupResource GetMockableDynatraceResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableDynatraceResourceGroupResource(client, resource.Id));
        }

        private static MockableDynatraceSubscriptionResource GetMockableDynatraceSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableDynatraceSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="DynatraceMonitorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DynatraceMonitorResource.CreateResourceIdentifier" /> to create a <see cref="DynatraceMonitorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDynatraceArmClient.GetDynatraceMonitorResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DynatraceMonitorResource"/> object. </returns>
        public static DynatraceMonitorResource GetDynatraceMonitorResource(this ArmClient client, ResourceIdentifier id)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            return GetMockableDynatraceArmClient(client).GetDynatraceMonitorResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DynatraceTagRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DynatraceTagRuleResource.CreateResourceIdentifier" /> to create a <see cref="DynatraceTagRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDynatraceArmClient.GetDynatraceTagRuleResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DynatraceTagRuleResource"/> object. </returns>
        public static DynatraceTagRuleResource GetDynatraceTagRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            return GetMockableDynatraceArmClient(client).GetDynatraceTagRuleResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DynatraceSingleSignOnResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DynatraceSingleSignOnResource.CreateResourceIdentifier" /> to create a <see cref="DynatraceSingleSignOnResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDynatraceArmClient.GetDynatraceSingleSignOnResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DynatraceSingleSignOnResource"/> object. </returns>
        public static DynatraceSingleSignOnResource GetDynatraceSingleSignOnResource(this ArmClient client, ResourceIdentifier id)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            return GetMockableDynatraceArmClient(client).GetDynatraceSingleSignOnResource(id);
        }

        /// <summary>
        /// Gets a collection of DynatraceMonitorResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDynatraceResourceGroupResource.GetDynatraceMonitors()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of DynatraceMonitorResources and their operations over a DynatraceMonitorResource. </returns>
        public static DynatraceMonitorCollection GetDynatraceMonitors(this ResourceGroupResource resourceGroupResource)
        {
            if (resourceGroupResource == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupResource));
            }

            return GetMockableDynatraceResourceGroupResource(resourceGroupResource).GetDynatraceMonitors();
        }

        /// <summary>
        /// Get a MonitorResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DynatraceMonitorResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDynatraceResourceGroupResource.GetDynatraceMonitorAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="monitorName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="monitorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<DynatraceMonitorResource>> GetDynatraceMonitorAsync(this ResourceGroupResource resourceGroupResource, string monitorName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupResource == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupResource));
            }

            return await GetMockableDynatraceResourceGroupResource(resourceGroupResource).GetDynatraceMonitorAsync(monitorName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a MonitorResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DynatraceMonitorResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDynatraceResourceGroupResource.GetDynatraceMonitor(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="monitorName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="monitorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<DynatraceMonitorResource> GetDynatraceMonitor(this ResourceGroupResource resourceGroupResource, string monitorName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupResource == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupResource));
            }

            return GetMockableDynatraceResourceGroupResource(resourceGroupResource).GetDynatraceMonitor(monitorName, cancellationToken);
        }

        /// <summary>
        /// List all MonitorResource by subscriptionId
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Dynatrace.Observability/monitors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_ListBySubscriptionId</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DynatraceMonitorResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDynatraceSubscriptionResource.GetDynatraceMonitors(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="DynatraceMonitorResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DynatraceMonitorResource> GetDynatraceMonitorsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            if (subscriptionResource == null)
            {
                throw new ArgumentNullException(nameof(subscriptionResource));
            }

            return GetMockableDynatraceSubscriptionResource(subscriptionResource).GetDynatraceMonitorsAsync(cancellationToken);
        }

        /// <summary>
        /// List all MonitorResource by subscriptionId
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Dynatrace.Observability/monitors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_ListBySubscriptionId</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DynatraceMonitorResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDynatraceSubscriptionResource.GetDynatraceMonitors(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="DynatraceMonitorResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DynatraceMonitorResource> GetDynatraceMonitors(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            if (subscriptionResource == null)
            {
                throw new ArgumentNullException(nameof(subscriptionResource));
            }

            return GetMockableDynatraceSubscriptionResource(subscriptionResource).GetDynatraceMonitors(cancellationToken);
        }
    }
}
