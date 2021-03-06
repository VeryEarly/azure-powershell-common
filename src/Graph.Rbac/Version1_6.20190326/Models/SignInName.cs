// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Graph.RBAC.Version1_6_20190326.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Contains information about a sign-in name of a local account user in an
    /// Azure Active Directory B2C tenant.
    /// </summary>
    public partial class SignInName
    {
        /// <summary>
        /// Initializes a new instance of the SignInName class.
        /// </summary>
        public SignInName()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SignInName class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="type">A string value that can be used to classify user
        /// sign-in types in your directory, such as 'emailAddress' or
        /// 'userName'.</param>
        /// <param name="value">The sign-in used by the local account. Must be
        /// unique across the company/tenant. For example,
        /// 'johnc@example.com'.</param>
        public SignInName(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string type = default(string), string value = default(string))
        {
            AdditionalProperties = additionalProperties;
            Type = type;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or sets a string value that can be used to classify user
        /// sign-in types in your directory, such as 'emailAddress' or
        /// 'userName'.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the sign-in used by the local account. Must be unique
        /// across the company/tenant. For example, 'johnc@example.com'.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
