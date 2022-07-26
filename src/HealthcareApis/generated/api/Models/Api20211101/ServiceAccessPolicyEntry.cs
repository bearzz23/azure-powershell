// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Extensions;

    /// <summary>An access policy entry.</summary>
    public partial class ServiceAccessPolicyEntry :
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceAccessPolicyEntry,
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServiceAccessPolicyEntryInternal
    {

        /// <summary>Backing field for <see cref="ObjectId" /> property.</summary>
        private string _objectId;

        /// <summary>
        /// An Azure AD object ID (User or Apps) that is allowed access to the FHIR service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Owned)]
        public string ObjectId { get => this._objectId; set => this._objectId = value; }

        /// <summary>Creates an new <see cref="ServiceAccessPolicyEntry" /> instance.</summary>
        public ServiceAccessPolicyEntry()
        {

        }
    }
    /// An access policy entry.
    public partial interface IServiceAccessPolicyEntry :
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.IJsonSerializable
    {
        /// <summary>
        /// An Azure AD object ID (User or Apps) that is allowed access to the FHIR service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"An Azure AD object ID (User or Apps) that is allowed access to the FHIR service.",
        SerializedName = @"objectId",
        PossibleTypes = new [] { typeof(string) })]
        string ObjectId { get; set; }

    }
    /// An access policy entry.
    internal partial interface IServiceAccessPolicyEntryInternal

    {
        /// <summary>
        /// An Azure AD object ID (User or Apps) that is allowed access to the FHIR service.
        /// </summary>
        string ObjectId { get; set; }

    }
}