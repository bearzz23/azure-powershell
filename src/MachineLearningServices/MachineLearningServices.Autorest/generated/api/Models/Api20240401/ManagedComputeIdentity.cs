// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Managed compute identity definition.</summary>
    public partial class ManagedComputeIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IManagedComputeIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IManagedComputeIdentityInternal,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitorComputeIdentityBase"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitorComputeIdentityBase __monitorComputeIdentityBase = new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.MonitorComputeIdentityBase();

        /// <summary>[Required] Specifies the type of identity to use within the monitoring jobs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MonitorComputeIdentityType ComputeIdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitorComputeIdentityBaseInternal)__monitorComputeIdentityBase).ComputeIdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitorComputeIdentityBaseInternal)__monitorComputeIdentityBase).ComputeIdentityType = value ; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IManagedServiceIdentity _identity;

        /// <summary>The identity which will be leveraged by the monitoring jobs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IManagedServiceIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.ManagedServiceIdentity()); set => this._identity = value; }

        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IManagedServiceIdentityInternal)Identity).PrincipalId; }

        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IManagedServiceIdentityInternal)Identity).TenantId; }

        /// <summary>
        /// Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ManagedServiceIdentityType? IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IManagedServiceIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IManagedServiceIdentityInternal)Identity).Type = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ManagedServiceIdentityType)""); }

        /// <summary>
        /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
        /// The dictionary values can be empty objects ({}) in requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IManagedServiceIdentity Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IManagedComputeIdentityInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.ManagedServiceIdentity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IManagedComputeIdentityInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IManagedServiceIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IManagedServiceIdentityInternal)Identity).PrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IManagedComputeIdentityInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IManagedServiceIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IManagedServiceIdentityInternal)Identity).TenantId = value; }

        /// <summary>Creates an new <see cref="ManagedComputeIdentity" /> instance.</summary>
        public ManagedComputeIdentity()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__monitorComputeIdentityBase), __monitorComputeIdentityBase);
            await eventListener.AssertObjectIsValid(nameof(__monitorComputeIdentityBase), __monitorComputeIdentityBase);
        }
    }
    /// Managed compute identity definition.
    public partial interface IManagedComputeIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitorComputeIdentityBase
    {
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }
        /// <summary>
        /// Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ManagedServiceIdentityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ManagedServiceIdentityType? IdentityType { get; set; }
        /// <summary>
        /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
        /// The dictionary values can be empty objects ({}) in requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}. The dictionary values can be empty objects ({}) in requests.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }

    }
    /// Managed compute identity definition.
    internal partial interface IManagedComputeIdentityInternal :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMonitorComputeIdentityBaseInternal
    {
        /// <summary>The identity which will be leveraged by the monitoring jobs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IManagedServiceIdentity Identity { get; set; }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityTenantId { get; set; }
        /// <summary>
        /// Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ManagedServiceIdentityType? IdentityType { get; set; }
        /// <summary>
        /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
        /// The dictionary values can be empty objects ({}) in requests.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }

    }
}