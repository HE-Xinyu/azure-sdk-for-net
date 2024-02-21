// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the UrlFileExtension condition for the delivery rule. </summary>
    public partial class DeliveryRuleUriFileExtensionCondition : DeliveryRuleCondition
    {
        /// <summary> Initializes a new instance of <see cref="DeliveryRuleUriFileExtensionCondition"/>. </summary>
        /// <param name="properties"> Defines the parameters for the condition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DeliveryRuleUriFileExtensionCondition(UriFileExtensionMatchCondition properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
            Name = MatchVariable.UriFileExtension;
        }

        /// <summary> Initializes a new instance of <see cref="DeliveryRuleUriFileExtensionCondition"/>. </summary>
        /// <param name="name"> The name of the condition for the delivery rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="properties"> Defines the parameters for the condition. </param>
        internal DeliveryRuleUriFileExtensionCondition(MatchVariable name, IDictionary<string, BinaryData> serializedAdditionalRawData, UriFileExtensionMatchCondition properties) : base(name, serializedAdditionalRawData)
        {
            Properties = properties;
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="DeliveryRuleUriFileExtensionCondition"/> for deserialization. </summary>
        internal DeliveryRuleUriFileExtensionCondition()
        {
        }

        /// <summary> Defines the parameters for the condition. </summary>
        public UriFileExtensionMatchCondition Properties { get; set; }
    }
}
