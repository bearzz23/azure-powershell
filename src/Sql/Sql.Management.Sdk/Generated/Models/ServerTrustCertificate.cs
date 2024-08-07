// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using System.Linq;

    /// <summary>
    /// Server trust certificate imported from box to enable connection between box
    /// and Sql Managed Instance.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ServerTrustCertificate : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the ServerTrustCertificate class.
        /// </summary>
        public ServerTrustCertificate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerTrustCertificate class.
        /// </summary>

        /// <param name="id">Resource ID.
        /// </param>

        /// <param name="name">Resource name.
        /// </param>

        /// <param name="type">Resource type.
        /// </param>

        /// <param name="publicBlob">The certificate public blob
        /// </param>

        /// <param name="thumbprint">The certificate thumbprint
        /// </param>

        /// <param name="certificateName">The certificate name
        /// </param>
        public ServerTrustCertificate(string id = default(string), string name = default(string), string type = default(string), string publicBlob = default(string), string thumbprint = default(string), string certificateName = default(string))

        : base(id, name, type)
        {
            this.PublicBlob = publicBlob;
            this.Thumbprint = thumbprint;
            this.CertificateName = certificateName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the certificate public blob
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.publicBlob")]
        public string PublicBlob {get; set; }

        /// <summary>
        /// Gets the certificate thumbprint
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.thumbprint")]
        public string Thumbprint {get; private set; }

        /// <summary>
        /// Gets the certificate name
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.certificateName")]
        public string CertificateName {get; private set; }
    }
}