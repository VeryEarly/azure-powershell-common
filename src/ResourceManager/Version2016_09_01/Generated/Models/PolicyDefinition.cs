// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Internal.Resources.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The policy definition.
    /// </summary>
    [JsonTransformation]
    public partial class PolicyDefinition : IResource
    {
        /// <summary>
        /// Initializes a new instance of the PolicyDefinition class.
        /// </summary>
        public PolicyDefinition() { }

        /// <summary>
        /// Initializes a new instance of the PolicyDefinition class.
        /// </summary>
        public PolicyDefinition(string policyType = default(string), string displayName = default(string), string description = default(string), object policyRule = default(object), string id = default(string), string name = default(string))
        {
            PolicyType = policyType;
            DisplayName = displayName;
            Description = description;
            PolicyRule = policyRule;
            Id = id;
            Name = name;
        }

        /// <summary>
        /// The type of policy definition. Possible values are NotSpecified,
        /// BuiltIn, and Custom. Possible values include: 'NotSpecified',
        /// 'BuiltIn', 'Custom'
        /// </summary>
        [JsonProperty(PropertyName = "properties.policyType")]
        public string PolicyType { get; set; }

        /// <summary>
        /// The display name of the policy definition.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The policy definition description.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// The policy rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.policyRule")]
        public object PolicyRule { get; set; }

        /// <summary>
        /// The ID of the policy definition.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the policy definition. If you do not specify a value
        /// for name, the value is inferred from the name value in the
        /// request URI.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
