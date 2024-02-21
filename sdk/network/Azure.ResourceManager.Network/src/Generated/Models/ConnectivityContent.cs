// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Parameters that determine how the connectivity check will be performed. </summary>
    public partial class ConnectivityContent
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ConnectivityContent"/>. </summary>
        /// <param name="source"> The source of the connection. </param>
        /// <param name="destination"> The destination of connection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> or <paramref name="destination"/> is null. </exception>
        public ConnectivityContent(ConnectivitySource source, ConnectivityDestination destination)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (destination == null)
            {
                throw new ArgumentNullException(nameof(destination));
            }

            Source = source;
            Destination = destination;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectivityContent"/>. </summary>
        /// <param name="source"> The source of the connection. </param>
        /// <param name="destination"> The destination of connection. </param>
        /// <param name="protocol"> Network protocol. </param>
        /// <param name="protocolConfiguration"> Configuration of the protocol. </param>
        /// <param name="preferredIPVersion"> Preferred IP version of the connection. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectivityContent(ConnectivitySource source, ConnectivityDestination destination, NetworkWatcherProtocol? protocol, ProtocolConfiguration protocolConfiguration, NetworkIPVersion? preferredIPVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Source = source;
            Destination = destination;
            Protocol = protocol;
            ProtocolConfiguration = protocolConfiguration;
            PreferredIPVersion = preferredIPVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectivityContent"/> for deserialization. </summary>
        internal ConnectivityContent()
        {
        }

        /// <summary> The source of the connection. </summary>
        public ConnectivitySource Source { get; }
        /// <summary> The destination of connection. </summary>
        public ConnectivityDestination Destination { get; }
        /// <summary> Network protocol. </summary>
        public NetworkWatcherProtocol? Protocol { get; set; }
        /// <summary> Configuration of the protocol. </summary>
        internal ProtocolConfiguration ProtocolConfiguration { get; set; }
        /// <summary> HTTP configuration of the connectivity check. </summary>
        public NetworkHttpConfiguration HttpProtocolConfiguration
        {
            get => ProtocolConfiguration is null ? default : ProtocolConfiguration.HttpProtocolConfiguration;
            set
            {
                if (ProtocolConfiguration is null)
                    ProtocolConfiguration = new ProtocolConfiguration();
                ProtocolConfiguration.HttpProtocolConfiguration = value;
            }
        }

        /// <summary> Preferred IP version of the connection. </summary>
        public NetworkIPVersion? PreferredIPVersion { get; set; }
    }
}
