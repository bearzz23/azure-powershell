// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Extensions;

    /// <summary>The configuration settings of the Azure Active Directory token validation flow.</summary>
    public partial class AzureActiveDirectoryValidation :
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryValidation,
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryValidationInternal
    {

        /// <summary>Backing field for <see cref="AllowedAudience" /> property.</summary>
        private string[] _allowedAudience;

        /// <summary>
        /// The list of audiences that can make successful authentication/authorization requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public string[] AllowedAudience { get => this._allowedAudience; set => this._allowedAudience = value; }

        /// <summary>The list of the allowed groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public string[] AllowedPrincipalGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IDefaultAuthorizationPolicyInternal)DefaultAuthorizationPolicy).AllowedPrincipalGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IDefaultAuthorizationPolicyInternal)DefaultAuthorizationPolicy).AllowedPrincipalGroup = value ?? null /* arrayOf */; }

        /// <summary>The list of the allowed identities.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public string[] AllowedPrincipalIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IDefaultAuthorizationPolicyInternal)DefaultAuthorizationPolicy).AllowedPrincipalIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IDefaultAuthorizationPolicyInternal)DefaultAuthorizationPolicy).AllowedPrincipalIdentity = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="DefaultAuthorizationPolicy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IDefaultAuthorizationPolicy _defaultAuthorizationPolicy;

        /// <summary>The configuration settings of the default authorization policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IDefaultAuthorizationPolicy DefaultAuthorizationPolicy { get => (this._defaultAuthorizationPolicy = this._defaultAuthorizationPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.DefaultAuthorizationPolicy()); set => this._defaultAuthorizationPolicy = value; }

        /// <summary>The configuration settings of the Azure Active Directory allowed applications.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public string[] DefaultAuthorizationPolicyAllowedApplication { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IDefaultAuthorizationPolicyInternal)DefaultAuthorizationPolicy).AllowedApplication; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IDefaultAuthorizationPolicyInternal)DefaultAuthorizationPolicy).AllowedApplication = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="JwtClaimCheck" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IJwtClaimChecks _jwtClaimCheck;

        /// <summary>
        /// The configuration settings of the checks that should be made while validating the JWT Claims.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IJwtClaimChecks JwtClaimCheck { get => (this._jwtClaimCheck = this._jwtClaimCheck ?? new Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.JwtClaimChecks()); set => this._jwtClaimCheck = value; }

        /// <summary>The list of the allowed client applications.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public string[] JwtClaimCheckAllowedClientApplication { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IJwtClaimChecksInternal)JwtClaimCheck).AllowedClientApplication; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IJwtClaimChecksInternal)JwtClaimCheck).AllowedClientApplication = value ?? null /* arrayOf */; }

        /// <summary>The list of the allowed groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Inlined)]
        public string[] JwtClaimCheckAllowedGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IJwtClaimChecksInternal)JwtClaimCheck).AllowedGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IJwtClaimChecksInternal)JwtClaimCheck).AllowedGroup = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for DefaultAuthorizationPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IDefaultAuthorizationPolicy Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryValidationInternal.DefaultAuthorizationPolicy { get => (this._defaultAuthorizationPolicy = this._defaultAuthorizationPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.DefaultAuthorizationPolicy()); set { {_defaultAuthorizationPolicy = value;} } }

        /// <summary>Internal Acessors for DefaultAuthorizationPolicyAllowedPrincipal</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAllowedPrincipals Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryValidationInternal.DefaultAuthorizationPolicyAllowedPrincipal { get => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IDefaultAuthorizationPolicyInternal)DefaultAuthorizationPolicy).AllowedPrincipal; set => ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IDefaultAuthorizationPolicyInternal)DefaultAuthorizationPolicy).AllowedPrincipal = value; }

        /// <summary>Internal Acessors for JwtClaimCheck</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IJwtClaimChecks Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAzureActiveDirectoryValidationInternal.JwtClaimCheck { get => (this._jwtClaimCheck = this._jwtClaimCheck ?? new Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.JwtClaimChecks()); set { {_jwtClaimCheck = value;} } }

        /// <summary>Creates an new <see cref="AzureActiveDirectoryValidation" /> instance.</summary>
        public AzureActiveDirectoryValidation()
        {

        }
    }
    /// The configuration settings of the Azure Active Directory token validation flow.
    public partial interface IAzureActiveDirectoryValidation :
        Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The list of audiences that can make successful authentication/authorization requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of audiences that can make successful authentication/authorization requests.",
        SerializedName = @"allowedAudiences",
        PossibleTypes = new [] { typeof(string) })]
        string[] AllowedAudience { get; set; }
        /// <summary>The list of the allowed groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of the allowed groups.",
        SerializedName = @"groups",
        PossibleTypes = new [] { typeof(string) })]
        string[] AllowedPrincipalGroup { get; set; }
        /// <summary>The list of the allowed identities.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of the allowed identities.",
        SerializedName = @"identities",
        PossibleTypes = new [] { typeof(string) })]
        string[] AllowedPrincipalIdentity { get; set; }
        /// <summary>The configuration settings of the Azure Active Directory allowed applications.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The configuration settings of the Azure Active Directory allowed applications.",
        SerializedName = @"allowedApplications",
        PossibleTypes = new [] { typeof(string) })]
        string[] DefaultAuthorizationPolicyAllowedApplication { get; set; }
        /// <summary>The list of the allowed client applications.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of the allowed client applications.",
        SerializedName = @"allowedClientApplications",
        PossibleTypes = new [] { typeof(string) })]
        string[] JwtClaimCheckAllowedClientApplication { get; set; }
        /// <summary>The list of the allowed groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of the allowed groups.",
        SerializedName = @"allowedGroups",
        PossibleTypes = new [] { typeof(string) })]
        string[] JwtClaimCheckAllowedGroup { get; set; }

    }
    /// The configuration settings of the Azure Active Directory token validation flow.
    internal partial interface IAzureActiveDirectoryValidationInternal

    {
        /// <summary>
        /// The list of audiences that can make successful authentication/authorization requests.
        /// </summary>
        string[] AllowedAudience { get; set; }
        /// <summary>The list of the allowed groups.</summary>
        string[] AllowedPrincipalGroup { get; set; }
        /// <summary>The list of the allowed identities.</summary>
        string[] AllowedPrincipalIdentity { get; set; }
        /// <summary>The configuration settings of the default authorization policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IDefaultAuthorizationPolicy DefaultAuthorizationPolicy { get; set; }
        /// <summary>The configuration settings of the Azure Active Directory allowed applications.</summary>
        string[] DefaultAuthorizationPolicyAllowedApplication { get; set; }
        /// <summary>The configuration settings of the Azure Active Directory allowed principals.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAllowedPrincipals DefaultAuthorizationPolicyAllowedPrincipal { get; set; }
        /// <summary>
        /// The configuration settings of the checks that should be made while validating the JWT Claims.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IJwtClaimChecks JwtClaimCheck { get; set; }
        /// <summary>The list of the allowed client applications.</summary>
        string[] JwtClaimCheckAllowedClientApplication { get; set; }
        /// <summary>The list of the allowed groups.</summary>
        string[] JwtClaimCheckAllowedGroup { get; set; }

    }
}