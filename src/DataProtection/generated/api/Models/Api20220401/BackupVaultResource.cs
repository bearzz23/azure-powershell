// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>Backup Vault Resource</summary>
    public partial class BackupVaultResource :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultResource,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResource __dppTrackedResource = new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.DppTrackedResource();

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState? AzureMonitorAlertsForAllJobFailure { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultInternal)Property).AzureMonitorAlertsForAllJobFailure; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultInternal)Property).AzureMonitorAlertsForAllJobFailure = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState)""); }

        /// <summary>Optional ETag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.DoNotFormat]
        public string ETag { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal)__dppTrackedResource).ETag; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal)__dppTrackedResource).ETag = value ?? null; }

        /// <summary>Resource Id represents the complete path to the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.DoNotFormat]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal)__dppTrackedResource).Id; }

        /// <summary>Input Managed Identity Details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppIdentityDetails Identity { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal)__dppTrackedResource).Identity; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal)__dppTrackedResource).Identity = value ?? null /* model class */; }

        /// <summary>
        /// The object ID of the service principal object for the managed identity that is used to grant role-based access to an Azure
        /// resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.DoNotFormat]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal)__dppTrackedResource).IdentityPrincipalId; }

        /// <summary>
        /// A Globally Unique Identifier (GUID) that represents the Azure AD tenant where the resource is now a member.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.DoNotFormat]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal)__dppTrackedResource).IdentityTenantId; }

        /// <summary>The identityType which can be either SystemAssigned or None</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.FormatTable(Index = 3)]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal)__dppTrackedResource).IdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal)__dppTrackedResource).IdentityType = value ?? null; }

        /// <summary>Resource location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.FormatTable(Index = 1)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal)__dppTrackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal)__dppTrackedResource).Location = value ?? null; }

        /// <summary>Internal Acessors for MonitoringSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IMonitoringSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultResourceInternal.MonitoringSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultInternal)Property).MonitoringSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultInternal)Property).MonitoringSetting = value; }

        /// <summary>Internal Acessors for MonitoringSettingAzureMonitorAlertSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IAzureMonitorAlertSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultResourceInternal.MonitoringSettingAzureMonitorAlertSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultInternal)Property).MonitoringSettingAzureMonitorAlertSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultInternal)Property).MonitoringSettingAzureMonitorAlertSetting = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVault Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.BackupVault()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for ResourceMoveDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IResourceMoveDetails Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultResourceInternal.ResourceMoveDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultInternal)Property).ResourceMoveDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultInternal)Property).ResourceMoveDetail = value; }

        /// <summary>Internal Acessors for ResourceMoveState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ResourceMoveState? Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultResourceInternal.ResourceMoveState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultInternal)Property).ResourceMoveState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultInternal)Property).ResourceMoveState = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal)__dppTrackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal)__dppTrackedResource).Id = value; }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal)__dppTrackedResource).IdentityPrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal)__dppTrackedResource).IdentityPrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal)__dppTrackedResource).IdentityTenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal)__dppTrackedResource).IdentityTenantId = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal)__dppTrackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal)__dppTrackedResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.ISystemData Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal)__dppTrackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal)__dppTrackedResource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal)__dppTrackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal)__dppTrackedResource).Type = value; }

        /// <summary>Resource name associated with the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.FormatTable(Index = 0)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal)__dppTrackedResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVault _property;

        /// <summary>BackupVaultResource properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVault Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.BackupVault()); set => this._property = value; }

        /// <summary>Provisioning state of the BackupVault resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultInternal)Property).ProvisioningState; }

        /// <summary>
        /// Completion time in UTC of latest ResourceMove operation attempted. ISO 8601 format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.DoNotFormat]
        public string ResourceMoveDetailCompletionTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultInternal)Property).ResourceMoveDetailCompletionTimeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultInternal)Property).ResourceMoveDetailCompletionTimeUtc = value ?? null; }

        /// <summary>CorrelationId of latest ResourceMove operation attempted</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.DoNotFormat]
        public string ResourceMoveDetailOperationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultInternal)Property).ResourceMoveDetailOperationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultInternal)Property).ResourceMoveDetailOperationId = value ?? null; }

        /// <summary>ARM resource path of source resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.DoNotFormat]
        public string ResourceMoveDetailSourceResourcePath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultInternal)Property).ResourceMoveDetailSourceResourcePath; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultInternal)Property).ResourceMoveDetailSourceResourcePath = value ?? null; }

        /// <summary>Start time in UTC of latest ResourceMove operation attempted. ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.DoNotFormat]
        public string ResourceMoveDetailStartTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultInternal)Property).ResourceMoveDetailStartTimeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultInternal)Property).ResourceMoveDetailStartTimeUtc = value ?? null; }

        /// <summary>ARM resource path of target resource used in latest ResourceMove operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.DoNotFormat]
        public string ResourceMoveDetailTargetResourcePath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultInternal)Property).ResourceMoveDetailTargetResourcePath; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultInternal)Property).ResourceMoveDetailTargetResourcePath = value ?? null; }

        /// <summary>Resource move state for backup vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ResourceMoveState? ResourceMoveState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultInternal)Property).ResourceMoveState; }

        /// <summary>Storage Settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IStorageSetting[] StorageSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultInternal)Property).StorageSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVaultInternal)Property).StorageSetting = value ; }

        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal)__dppTrackedResource).SystemData; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal)__dppTrackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal)__dppTrackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// Resource type represents the complete path of the form Namespace/ResourceType/ResourceType/...
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.FormatTable(Index = 2)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal)__dppTrackedResource).Type; }

        /// <summary>Creates an new <see cref="BackupVaultResource" /> instance.</summary>
        public BackupVaultResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__dppTrackedResource), __dppTrackedResource);
            await eventListener.AssertObjectIsValid(nameof(__dppTrackedResource), __dppTrackedResource);
        }
    }
    /// Backup Vault Resource
    public partial interface IBackupVaultResource :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResource
    {
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"alertsForAllJobFailures",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState? AzureMonitorAlertsForAllJobFailure { get; set; }
        /// <summary>Provisioning state of the BackupVault resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning state of the BackupVault resource",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>
        /// Completion time in UTC of latest ResourceMove operation attempted. ISO 8601 format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Completion time in UTC of latest ResourceMove operation attempted. ISO 8601 format.",
        SerializedName = @"completionTimeUtc",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceMoveDetailCompletionTimeUtc { get; set; }
        /// <summary>CorrelationId of latest ResourceMove operation attempted</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"CorrelationId of latest ResourceMove operation attempted",
        SerializedName = @"operationId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceMoveDetailOperationId { get; set; }
        /// <summary>ARM resource path of source resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ARM resource path of source resource",
        SerializedName = @"sourceResourcePath",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceMoveDetailSourceResourcePath { get; set; }
        /// <summary>Start time in UTC of latest ResourceMove operation attempted. ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Start time in UTC of latest ResourceMove operation attempted. ISO 8601 format.",
        SerializedName = @"startTimeUtc",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceMoveDetailStartTimeUtc { get; set; }
        /// <summary>ARM resource path of target resource used in latest ResourceMove operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ARM resource path of target resource used in latest ResourceMove operation",
        SerializedName = @"targetResourcePath",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceMoveDetailTargetResourcePath { get; set; }
        /// <summary>Resource move state for backup vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Resource move state for backup vault",
        SerializedName = @"resourceMoveState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ResourceMoveState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ResourceMoveState? ResourceMoveState { get;  }
        /// <summary>Storage Settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Storage Settings",
        SerializedName = @"storageSettings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IStorageSetting) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IStorageSetting[] StorageSetting { get; set; }

    }
    /// Backup Vault Resource
    internal partial interface IBackupVaultResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IDppTrackedResourceInternal
    {
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState? AzureMonitorAlertsForAllJobFailure { get; set; }
        /// <summary>Monitoring Settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IMonitoringSettings MonitoringSetting { get; set; }
        /// <summary>Settings for Azure Monitor based alerts</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IAzureMonitorAlertSettings MonitoringSettingAzureMonitorAlertSetting { get; set; }
        /// <summary>BackupVaultResource properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IBackupVault Property { get; set; }
        /// <summary>Provisioning state of the BackupVault resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Resource move details for backup vault</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IResourceMoveDetails ResourceMoveDetail { get; set; }
        /// <summary>
        /// Completion time in UTC of latest ResourceMove operation attempted. ISO 8601 format.
        /// </summary>
        string ResourceMoveDetailCompletionTimeUtc { get; set; }
        /// <summary>CorrelationId of latest ResourceMove operation attempted</summary>
        string ResourceMoveDetailOperationId { get; set; }
        /// <summary>ARM resource path of source resource</summary>
        string ResourceMoveDetailSourceResourcePath { get; set; }
        /// <summary>Start time in UTC of latest ResourceMove operation attempted. ISO 8601 format.</summary>
        string ResourceMoveDetailStartTimeUtc { get; set; }
        /// <summary>ARM resource path of target resource used in latest ResourceMove operation</summary>
        string ResourceMoveDetailTargetResourcePath { get; set; }
        /// <summary>Resource move state for backup vault</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ResourceMoveState? ResourceMoveState { get; set; }
        /// <summary>Storage Settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api20220401.IStorageSetting[] StorageSetting { get; set; }

    }
}