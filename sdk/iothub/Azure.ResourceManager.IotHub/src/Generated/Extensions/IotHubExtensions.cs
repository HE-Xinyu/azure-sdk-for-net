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
using Azure.ResourceManager.IotHub.Mocking;
using Azure.ResourceManager.IotHub.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.IotHub
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.IotHub. </summary>
    public static partial class IotHubExtensions
    {
        private static MockableIotHubArmClient GetMockableIotHubArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableIotHubArmClient(client0));
        }

        private static MockableIotHubResourceGroupResource GetMockableIotHubResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableIotHubResourceGroupResource(client, resource.Id));
        }

        private static MockableIotHubSubscriptionResource GetMockableIotHubSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableIotHubSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing an <see cref="IotHubDescriptionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="IotHubDescriptionResource.CreateResourceIdentifier" /> to create an <see cref="IotHubDescriptionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotHubArmClient.GetIotHubDescriptionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="IotHubDescriptionResource"/> object. </returns>
        public static IotHubDescriptionResource GetIotHubDescriptionResource(this ArmClient client, ResourceIdentifier id)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            return GetMockableIotHubArmClient(client).GetIotHubDescriptionResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="EventHubConsumerGroupInfoResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EventHubConsumerGroupInfoResource.CreateResourceIdentifier" /> to create an <see cref="EventHubConsumerGroupInfoResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotHubArmClient.GetEventHubConsumerGroupInfoResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="EventHubConsumerGroupInfoResource"/> object. </returns>
        public static EventHubConsumerGroupInfoResource GetEventHubConsumerGroupInfoResource(this ArmClient client, ResourceIdentifier id)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            return GetMockableIotHubArmClient(client).GetEventHubConsumerGroupInfoResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="IotHubCertificateDescriptionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="IotHubCertificateDescriptionResource.CreateResourceIdentifier" /> to create an <see cref="IotHubCertificateDescriptionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotHubArmClient.GetIotHubCertificateDescriptionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="IotHubCertificateDescriptionResource"/> object. </returns>
        public static IotHubCertificateDescriptionResource GetIotHubCertificateDescriptionResource(this ArmClient client, ResourceIdentifier id)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            return GetMockableIotHubArmClient(client).GetIotHubCertificateDescriptionResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="IotHubPrivateEndpointGroupInformationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="IotHubPrivateEndpointGroupInformationResource.CreateResourceIdentifier" /> to create an <see cref="IotHubPrivateEndpointGroupInformationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotHubArmClient.GetIotHubPrivateEndpointGroupInformationResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="IotHubPrivateEndpointGroupInformationResource"/> object. </returns>
        public static IotHubPrivateEndpointGroupInformationResource GetIotHubPrivateEndpointGroupInformationResource(this ArmClient client, ResourceIdentifier id)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            return GetMockableIotHubArmClient(client).GetIotHubPrivateEndpointGroupInformationResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="IotHubPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="IotHubPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create an <see cref="IotHubPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotHubArmClient.GetIotHubPrivateEndpointConnectionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="IotHubPrivateEndpointConnectionResource"/> object. </returns>
        public static IotHubPrivateEndpointConnectionResource GetIotHubPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            return GetMockableIotHubArmClient(client).GetIotHubPrivateEndpointConnectionResource(id);
        }

        /// <summary>
        /// Gets a collection of IotHubDescriptionResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotHubResourceGroupResource.GetIotHubDescriptions()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of IotHubDescriptionResources and their operations over a IotHubDescriptionResource. </returns>
        public static IotHubDescriptionCollection GetIotHubDescriptions(this ResourceGroupResource resourceGroupResource)
        {
            if (resourceGroupResource == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupResource));
            }

            return GetMockableIotHubResourceGroupResource(resourceGroupResource).GetIotHubDescriptions();
        }

        /// <summary>
        /// Get the non-security related metadata of an IoT hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotHubResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-30</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotHubDescriptionResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotHubResourceGroupResource.GetIotHubDescriptionAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="resourceName"> The name of the IoT hub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<IotHubDescriptionResource>> GetIotHubDescriptionAsync(this ResourceGroupResource resourceGroupResource, string resourceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupResource == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupResource));
            }

            return await GetMockableIotHubResourceGroupResource(resourceGroupResource).GetIotHubDescriptionAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the non-security related metadata of an IoT hub.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/IotHubs/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotHubResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-30</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotHubDescriptionResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotHubResourceGroupResource.GetIotHubDescription(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="resourceName"> The name of the IoT hub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<IotHubDescriptionResource> GetIotHubDescription(this ResourceGroupResource resourceGroupResource, string resourceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupResource == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupResource));
            }

            return GetMockableIotHubResourceGroupResource(resourceGroupResource).GetIotHubDescription(resourceName, cancellationToken);
        }

        /// <summary>
        /// Get all the IoT hubs in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Devices/IotHubs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotHubResource_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-30</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotHubDescriptionResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotHubSubscriptionResource.GetIotHubDescriptions(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="IotHubDescriptionResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<IotHubDescriptionResource> GetIotHubDescriptionsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            if (subscriptionResource == null)
            {
                throw new ArgumentNullException(nameof(subscriptionResource));
            }

            return GetMockableIotHubSubscriptionResource(subscriptionResource).GetIotHubDescriptionsAsync(cancellationToken);
        }

        /// <summary>
        /// Get all the IoT hubs in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Devices/IotHubs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotHubResource_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-30</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotHubDescriptionResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotHubSubscriptionResource.GetIotHubDescriptions(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="IotHubDescriptionResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<IotHubDescriptionResource> GetIotHubDescriptions(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            if (subscriptionResource == null)
            {
                throw new ArgumentNullException(nameof(subscriptionResource));
            }

            return GetMockableIotHubSubscriptionResource(subscriptionResource).GetIotHubDescriptions(cancellationToken);
        }

        /// <summary>
        /// Check if an IoT hub name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Devices/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotHubResource_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-30</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotHubDescriptionResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotHubSubscriptionResource.CheckIotHubNameAvailability(IotHubNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Set the name parameter in the OperationInputs structure to the name of the IoT hub to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<IotHubNameAvailabilityResponse>> CheckIotHubNameAvailabilityAsync(this SubscriptionResource subscriptionResource, IotHubNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            if (subscriptionResource == null)
            {
                throw new ArgumentNullException(nameof(subscriptionResource));
            }

            return await GetMockableIotHubSubscriptionResource(subscriptionResource).CheckIotHubNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check if an IoT hub name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Devices/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IotHubResource_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-30</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotHubDescriptionResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotHubSubscriptionResource.CheckIotHubNameAvailability(IotHubNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Set the name parameter in the OperationInputs structure to the name of the IoT hub to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static Response<IotHubNameAvailabilityResponse> CheckIotHubNameAvailability(this SubscriptionResource subscriptionResource, IotHubNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            if (subscriptionResource == null)
            {
                throw new ArgumentNullException(nameof(subscriptionResource));
            }

            return GetMockableIotHubSubscriptionResource(subscriptionResource).CheckIotHubNameAvailability(content, cancellationToken);
        }

        /// <summary>
        /// Get the number of free and paid iot hubs in the subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Devices/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceProviderCommon_GetSubscriptionQuota</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-30</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotHubSubscriptionResource.GetIotHubUserSubscriptionQuota(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="IotHubUserSubscriptionQuota"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<IotHubUserSubscriptionQuota> GetIotHubUserSubscriptionQuotaAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            if (subscriptionResource == null)
            {
                throw new ArgumentNullException(nameof(subscriptionResource));
            }

            return GetMockableIotHubSubscriptionResource(subscriptionResource).GetIotHubUserSubscriptionQuotaAsync(cancellationToken);
        }

        /// <summary>
        /// Get the number of free and paid iot hubs in the subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Devices/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceProviderCommon_GetSubscriptionQuota</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-30</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIotHubSubscriptionResource.GetIotHubUserSubscriptionQuota(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="IotHubUserSubscriptionQuota"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<IotHubUserSubscriptionQuota> GetIotHubUserSubscriptionQuota(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            if (subscriptionResource == null)
            {
                throw new ArgumentNullException(nameof(subscriptionResource));
            }

            return GetMockableIotHubSubscriptionResource(subscriptionResource).GetIotHubUserSubscriptionQuota(cancellationToken);
        }
    }
}
