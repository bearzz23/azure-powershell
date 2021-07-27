namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>A2A unprotected disk details.</summary>
    public partial class A2AUnprotectedDiskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AUnprotectedDiskDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2AUnprotectedDiskDetailsInternal
    {

        /// <summary>Backing field for <see cref="DiskAutoProtectionStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AutoProtectionOfDataDisk? _diskAutoProtectionStatus;

        /// <summary>A value indicating whether the disk auto protection is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AutoProtectionOfDataDisk? DiskAutoProtectionStatus { get => this._diskAutoProtectionStatus; set => this._diskAutoProtectionStatus = value; }

        /// <summary>Backing field for <see cref="DiskLunId" /> property.</summary>
        private int? _diskLunId;

        /// <summary>The source lun Id for the data disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public int? DiskLunId { get => this._diskLunId; set => this._diskLunId = value; }

        /// <summary>Creates an new <see cref="A2AUnprotectedDiskDetails" /> instance.</summary>
        public A2AUnprotectedDiskDetails()
        {

        }
    }
    /// A2A unprotected disk details.
    public partial interface IA2AUnprotectedDiskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>A value indicating whether the disk auto protection is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether the disk auto protection is enabled.",
        SerializedName = @"diskAutoProtectionStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AutoProtectionOfDataDisk) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AutoProtectionOfDataDisk? DiskAutoProtectionStatus { get; set; }
        /// <summary>The source lun Id for the data disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The source lun Id for the data disk.",
        SerializedName = @"diskLunId",
        PossibleTypes = new [] { typeof(int) })]
        int? DiskLunId { get; set; }

    }
    /// A2A unprotected disk details.
    internal partial interface IA2AUnprotectedDiskDetailsInternal

    {
        /// <summary>A value indicating whether the disk auto protection is enabled.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.AutoProtectionOfDataDisk? DiskAutoProtectionStatus { get; set; }
        /// <summary>The source lun Id for the data disk.</summary>
        int? DiskLunId { get; set; }

    }
}