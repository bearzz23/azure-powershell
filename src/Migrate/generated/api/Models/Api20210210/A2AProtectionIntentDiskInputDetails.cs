namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Azure VM unmanaged disk input details.</summary>
    public partial class A2AProtectionIntentDiskInputDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetailsInternal
    {

        /// <summary>Backing field for <see cref="DiskUri" /> property.</summary>
        private string _diskUri;

        /// <summary>The disk Uri.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiskUri { get => this._diskUri; set => this._diskUri = value; }

        /// <summary>Internal Acessors for PrimaryStagingStorageAccountCustomInput</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetailsInternal.PrimaryStagingStorageAccountCustomInput { get => (this._primaryStagingStorageAccountCustomInput = this._primaryStagingStorageAccountCustomInput ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.StorageAccountCustomDetails()); set { {_primaryStagingStorageAccountCustomInput = value;} } }

        /// <summary>Internal Acessors for RecoveryAzureStorageAccountCustomInput</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetails Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AProtectionIntentDiskInputDetailsInternal.RecoveryAzureStorageAccountCustomInput { get => (this._recoveryAzureStorageAccountCustomInput = this._recoveryAzureStorageAccountCustomInput ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.StorageAccountCustomDetails()); set { {_recoveryAzureStorageAccountCustomInput = value;} } }

        /// <summary>
        /// Backing field for <see cref="PrimaryStagingStorageAccountCustomInput" /> property.
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetails _primaryStagingStorageAccountCustomInput;

        /// <summary>The primary staging storage account input.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetails PrimaryStagingStorageAccountCustomInput { get => (this._primaryStagingStorageAccountCustomInput = this._primaryStagingStorageAccountCustomInput ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.StorageAccountCustomDetails()); set => this._primaryStagingStorageAccountCustomInput = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string PrimaryStagingStorageAccountCustomInputResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetailsInternal)PrimaryStagingStorageAccountCustomInput).ResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetailsInternal)PrimaryStagingStorageAccountCustomInput).ResourceType = value ?? null; }

        /// <summary>
        /// Backing field for <see cref="RecoveryAzureStorageAccountCustomInput" /> property.
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetails _recoveryAzureStorageAccountCustomInput;

        /// <summary>The recovery VHD storage account input.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetails RecoveryAzureStorageAccountCustomInput { get => (this._recoveryAzureStorageAccountCustomInput = this._recoveryAzureStorageAccountCustomInput ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.StorageAccountCustomDetails()); set => this._recoveryAzureStorageAccountCustomInput = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string RecoveryAzureStorageAccountCustomInputResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetailsInternal)RecoveryAzureStorageAccountCustomInput).ResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetailsInternal)RecoveryAzureStorageAccountCustomInput).ResourceType = value ?? null; }

        /// <summary>Creates an new <see cref="A2AProtectionIntentDiskInputDetails" /> instance.</summary>
        public A2AProtectionIntentDiskInputDetails()
        {

        }
    }
    /// Azure VM unmanaged disk input details.
    public partial interface IA2AProtectionIntentDiskInputDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The disk Uri.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The disk Uri.",
        SerializedName = @"diskUri",
        PossibleTypes = new [] { typeof(string) })]
        string DiskUri { get; set; }
        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The class type.",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string PrimaryStagingStorageAccountCustomInputResourceType { get; set; }
        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The class type.",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryAzureStorageAccountCustomInputResourceType { get; set; }

    }
    /// Azure VM unmanaged disk input details.
    internal partial interface IA2AProtectionIntentDiskInputDetailsInternal

    {
        /// <summary>The disk Uri.</summary>
        string DiskUri { get; set; }
        /// <summary>The primary staging storage account input.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetails PrimaryStagingStorageAccountCustomInput { get; set; }
        /// <summary>The class type.</summary>
        string PrimaryStagingStorageAccountCustomInputResourceType { get; set; }
        /// <summary>The recovery VHD storage account input.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IStorageAccountCustomDetails RecoveryAzureStorageAccountCustomInput { get; set; }
        /// <summary>The class type.</summary>
        string RecoveryAzureStorageAccountCustomInputResourceType { get; set; }

    }
}