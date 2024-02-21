// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.AgFoodPlatform.Models
{
    /// <summary> Unit systems info for the data provider. </summary>
    public partial class UnitSystemsInfo
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

        /// <summary> Initializes a new instance of <see cref="UnitSystemsInfo"/>. </summary>
        /// <param name="key"> UnitSystem key sent as part of ProviderInput. </param>
        /// <param name="values"> List of unit systems supported by this data provider. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="values"/> is null. </exception>
        internal UnitSystemsInfo(string key, IEnumerable<string> values)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            Key = key;
            Values = values.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="UnitSystemsInfo"/>. </summary>
        /// <param name="key"> UnitSystem key sent as part of ProviderInput. </param>
        /// <param name="values"> List of unit systems supported by this data provider. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnitSystemsInfo(string key, IReadOnlyList<string> values, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Key = key;
            Values = values;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="UnitSystemsInfo"/> for deserialization. </summary>
        internal UnitSystemsInfo()
        {
        }

        /// <summary> UnitSystem key sent as part of ProviderInput. </summary>
        public string Key { get; }
        /// <summary> List of unit systems supported by this data provider. </summary>
        public IReadOnlyList<string> Values { get; }
    }
}
