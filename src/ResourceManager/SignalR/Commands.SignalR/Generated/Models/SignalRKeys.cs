// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.SignalR.Generated.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A class represents the access keys of SignalR service.
    /// </summary>
    public partial class SignalRKeys
    {
        /// <summary>
        /// Initializes a new instance of the SignalRKeys class.
        /// </summary>
        public SignalRKeys()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SignalRKeys class.
        /// </summary>
        /// <param name="primaryKey">The primary access key.</param>
        /// <param name="secondaryKey">The secondary access key.</param>
        public SignalRKeys(string primaryKey = default(string), string secondaryKey = default(string))
        {
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the primary access key.
        /// </summary>
        [JsonProperty(PropertyName = "primaryKey")]
        public string PrimaryKey { get; set; }

        /// <summary>
        /// Gets or sets the secondary access key.
        /// </summary>
        [JsonProperty(PropertyName = "secondaryKey")]
        public string SecondaryKey { get; set; }

    }
}
