// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Extensions;

    public partial class ContactProfilesUpdateTagsAcceptedResponseHeaders :
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactProfilesUpdateTagsAcceptedResponseHeaders,
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactProfilesUpdateTagsAcceptedResponseHeadersInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.IHeaderSerializable
    {

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>
        /// Creates an new <see cref="ContactProfilesUpdateTagsAcceptedResponseHeaders" /> instance.
        /// </summary>
        public ContactProfilesUpdateTagsAcceptedResponseHeaders()
        {

        }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Location", out var __locationHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactProfilesUpdateTagsAcceptedResponseHeadersInternal)this).Location = System.Linq.Enumerable.FirstOrDefault(__locationHeader0) is string __headerLocationHeader0 ? __headerLocationHeader0 : (string)null;
            }
        }
    }
    public partial interface IContactProfilesUpdateTagsAcceptedResponseHeaders

    {
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"Location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }

    }
    internal partial interface IContactProfilesUpdateTagsAcceptedResponseHeadersInternal

    {
        string Location { get; set; }

    }
}