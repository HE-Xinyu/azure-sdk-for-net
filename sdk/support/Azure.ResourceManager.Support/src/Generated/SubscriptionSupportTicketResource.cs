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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Support.Models;

namespace Azure.ResourceManager.Support
{
    /// <summary>
    /// A Class representing a SubscriptionSupportTicket along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SubscriptionSupportTicketResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSubscriptionSupportTicketResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetSubscriptionSupportTicket method.
    /// </summary>
    public partial class SubscriptionSupportTicketResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SubscriptionSupportTicketResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="supportTicketName"> The supportTicketName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string supportTicketName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _subscriptionSupportTicketSupportTicketsClientDiagnostics;
        private readonly SupportTicketsRestOperations _subscriptionSupportTicketSupportTicketsRestClient;
        private readonly ClientDiagnostics _supportTicketCommunicationCommunicationsClientDiagnostics;
        private readonly CommunicationsRestOperations _supportTicketCommunicationCommunicationsRestClient;
        private readonly SupportTicketData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Support/supportTickets";

        /// <summary> Initializes a new instance of the <see cref="SubscriptionSupportTicketResource"/> class for mocking. </summary>
        protected SubscriptionSupportTicketResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionSupportTicketResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SubscriptionSupportTicketResource(ArmClient client, SupportTicketData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionSupportTicketResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionSupportTicketResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subscriptionSupportTicketSupportTicketsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Support", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string subscriptionSupportTicketSupportTicketsApiVersion);
            _subscriptionSupportTicketSupportTicketsRestClient = new SupportTicketsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionSupportTicketSupportTicketsApiVersion);
            _supportTicketCommunicationCommunicationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Support", SupportTicketCommunicationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SupportTicketCommunicationResource.ResourceType, out string supportTicketCommunicationCommunicationsApiVersion);
            _supportTicketCommunicationCommunicationsRestClient = new CommunicationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, supportTicketCommunicationCommunicationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SupportTicketData Data
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

        /// <summary> Gets a collection of SupportTicketCommunicationResources in the SubscriptionSupportTicket. </summary>
        /// <returns> An object representing collection of SupportTicketCommunicationResources and their operations over a SupportTicketCommunicationResource. </returns>
        public virtual SupportTicketCommunicationCollection GetSupportTicketCommunications()
        {
            return GetCachedClient(client => new SupportTicketCommunicationCollection(client, Id));
        }

        /// <summary>
        /// Returns communication details for a support ticket.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/communications/{communicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Communications_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SupportTicketCommunicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="communicationName"> Communication name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="communicationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SupportTicketCommunicationResource>> GetSupportTicketCommunicationAsync(string communicationName, CancellationToken cancellationToken = default)
        {
            return await GetSupportTicketCommunications().GetAsync(communicationName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns communication details for a support ticket.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/communications/{communicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Communications_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SupportTicketCommunicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="communicationName"> Communication name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="communicationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SupportTicketCommunicationResource> GetSupportTicketCommunication(string communicationName, CancellationToken cancellationToken = default)
        {
            return GetSupportTicketCommunications().Get(communicationName, cancellationToken);
        }

        /// <summary> Gets a collection of SupportTicketChatTranscriptResources in the SubscriptionSupportTicket. </summary>
        /// <returns> An object representing collection of SupportTicketChatTranscriptResources and their operations over a SupportTicketChatTranscriptResource. </returns>
        public virtual SupportTicketChatTranscriptCollection GetSupportTicketChatTranscripts()
        {
            return GetCachedClient(client => new SupportTicketChatTranscriptCollection(client, Id));
        }

        /// <summary>
        /// Returns chatTranscript details for a support ticket under a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/chatTranscripts/{chatTranscriptName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChatTranscripts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SupportTicketChatTranscriptResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="chatTranscriptName"> ChatTranscript name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="chatTranscriptName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="chatTranscriptName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SupportTicketChatTranscriptResource>> GetSupportTicketChatTranscriptAsync(string chatTranscriptName, CancellationToken cancellationToken = default)
        {
            return await GetSupportTicketChatTranscripts().GetAsync(chatTranscriptName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns chatTranscript details for a support ticket under a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/chatTranscripts/{chatTranscriptName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChatTranscripts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SupportTicketChatTranscriptResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="chatTranscriptName"> ChatTranscript name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="chatTranscriptName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="chatTranscriptName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SupportTicketChatTranscriptResource> GetSupportTicketChatTranscript(string chatTranscriptName, CancellationToken cancellationToken = default)
        {
            return GetSupportTicketChatTranscripts().Get(chatTranscriptName, cancellationToken);
        }

        /// <summary>
        /// Get ticket details for an Azure subscription. Support ticket data is available for 18 months after ticket creation. If a ticket was created more than 18 months ago, a request for data might cause an error.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupportTickets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionSupportTicketResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SubscriptionSupportTicketResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionSupportTicketSupportTicketsClientDiagnostics.CreateScope("SubscriptionSupportTicketResource.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionSupportTicketSupportTicketsRestClient.GetAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionSupportTicketResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get ticket details for an Azure subscription. Support ticket data is available for 18 months after ticket creation. If a ticket was created more than 18 months ago, a request for data might cause an error.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupportTickets_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionSupportTicketResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SubscriptionSupportTicketResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionSupportTicketSupportTicketsClientDiagnostics.CreateScope("SubscriptionSupportTicketResource.Get");
            scope.Start();
            try
            {
                var response = _subscriptionSupportTicketSupportTicketsRestClient.Get(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionSupportTicketResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This API allows you to update the severity level, ticket status, advanced diagnostic consent and your contact information in the support ticket.&lt;br/&gt;&lt;br/&gt;Note: The severity levels cannot be changed if a support ticket is actively being worked upon by an Azure support engineer. In such a case, contact your support engineer to request severity update by adding a new communication using the Communications API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupportTickets_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionSupportTicketResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateSupportTicket"> UpdateSupportTicket object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="updateSupportTicket"/> is null. </exception>
        public virtual async Task<Response<SubscriptionSupportTicketResource>> UpdateAsync(UpdateSupportTicket updateSupportTicket, CancellationToken cancellationToken = default)
        {
            if (updateSupportTicket == null)
            {
                throw new ArgumentNullException(nameof(updateSupportTicket));
            }

            using var scope = _subscriptionSupportTicketSupportTicketsClientDiagnostics.CreateScope("SubscriptionSupportTicketResource.Update");
            scope.Start();
            try
            {
                var response = await _subscriptionSupportTicketSupportTicketsRestClient.UpdateAsync(Id.SubscriptionId, Id.Name, updateSupportTicket, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SubscriptionSupportTicketResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This API allows you to update the severity level, ticket status, advanced diagnostic consent and your contact information in the support ticket.&lt;br/&gt;&lt;br/&gt;Note: The severity levels cannot be changed if a support ticket is actively being worked upon by an Azure support engineer. In such a case, contact your support engineer to request severity update by adding a new communication using the Communications API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupportTickets_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionSupportTicketResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="updateSupportTicket"> UpdateSupportTicket object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="updateSupportTicket"/> is null. </exception>
        public virtual Response<SubscriptionSupportTicketResource> Update(UpdateSupportTicket updateSupportTicket, CancellationToken cancellationToken = default)
        {
            if (updateSupportTicket == null)
            {
                throw new ArgumentNullException(nameof(updateSupportTicket));
            }

            using var scope = _subscriptionSupportTicketSupportTicketsClientDiagnostics.CreateScope("SubscriptionSupportTicketResource.Update");
            scope.Start();
            try
            {
                var response = _subscriptionSupportTicketSupportTicketsRestClient.Update(Id.SubscriptionId, Id.Name, updateSupportTicket, cancellationToken);
                return Response.FromValue(new SubscriptionSupportTicketResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the availability of a resource name. This API should be used to check the uniqueness of the name for adding a new communication to the support ticket.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Communications_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SupportTicketCommunicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<SupportNameAvailabilityResult>> CheckCommunicationNameAvailabilityAsync(SupportNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = _supportTicketCommunicationCommunicationsClientDiagnostics.CreateScope("SubscriptionSupportTicketResource.CheckCommunicationNameAvailability");
            scope.Start();
            try
            {
                var response = await _supportTicketCommunicationCommunicationsRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, Id.Name, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the availability of a resource name. This API should be used to check the uniqueness of the name for adding a new communication to the support ticket.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Communications_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SupportTicketCommunicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<SupportNameAvailabilityResult> CheckCommunicationNameAvailability(SupportNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = _supportTicketCommunicationCommunicationsClientDiagnostics.CreateScope("SubscriptionSupportTicketResource.CheckCommunicationNameAvailability");
            scope.Start();
            try
            {
                var response = _supportTicketCommunicationCommunicationsRestClient.CheckNameAvailability(Id.SubscriptionId, Id.Name, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
