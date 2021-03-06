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
    public partial class PolicyAssignment : IResource
    {
        /// <summary>
        /// Initializes a new instance of the PolicyAssignment class.
        /// </summary>
        public PolicyAssignment() { }

        /// <summary>
        /// Initializes a new instance of the PolicyAssignment class.
        /// </summary>
        public PolicyAssignment(string displayName = default(string), string policyDefinitionId = default(string), string scope = default(string), string id = default(string), string type = default(string), string name = default(string))
        {
            DisplayName = displayName;
            PolicyDefinitionId = policyDefinitionId;
            Scope = scope;
            Id = id;
            Type = type;
            Name = name;
        }

        /// <summary>
        /// The display name of the policy assignment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The ID of the policy definition.
        /// </summary>
        [JsonProperty(PropertyName = "properties.policyDefinitionId")]
        public string PolicyDefinitionId { get; set; }

        /// <summary>
        /// The scope for the policy assignment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scope")]
        public string Scope { get; set; }

        /// <summary>
        /// The ID of the policy assignment.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The type of the policy assignment.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// The name of the policy assignment.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
