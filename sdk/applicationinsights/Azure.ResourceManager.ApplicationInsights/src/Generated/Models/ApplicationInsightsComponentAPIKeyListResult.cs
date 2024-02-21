// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> Describes the list of API Keys of an Application Insights Component. </summary>
    internal partial class ApplicationInsightsComponentAPIKeyListResult
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

        /// <summary> Initializes a new instance of <see cref="ApplicationInsightsComponentAPIKeyListResult"/>. </summary>
        /// <param name="value"> List of API Key definitions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ApplicationInsightsComponentAPIKeyListResult(IEnumerable<ApplicationInsightsComponentAPIKey> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationInsightsComponentAPIKeyListResult"/>. </summary>
        /// <param name="value"> List of API Key definitions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationInsightsComponentAPIKeyListResult(IReadOnlyList<ApplicationInsightsComponentAPIKey> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationInsightsComponentAPIKeyListResult"/> for deserialization. </summary>
        internal ApplicationInsightsComponentAPIKeyListResult()
        {
        }

        /// <summary> List of API Key definitions. </summary>
        public IReadOnlyList<ApplicationInsightsComponentAPIKey> Value { get; }
    }
}
