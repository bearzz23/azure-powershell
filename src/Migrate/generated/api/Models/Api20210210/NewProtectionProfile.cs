namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>New Protection profile input.</summary>
    public partial class NewProtectionProfile :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INewProtectionProfile,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INewProtectionProfileInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionProfileCustomDetails"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionProfileCustomDetails __protectionProfileCustomDetails = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ProtectionProfileCustomDetails();

        /// <summary>Backing field for <see cref="AppConsistentFrequencyInMinute" /> property.</summary>
        private int? _appConsistentFrequencyInMinute;

        /// <summary>The app consistent snapshot frequency (in minutes).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public int? AppConsistentFrequencyInMinute { get => this._appConsistentFrequencyInMinute; set => this._appConsistentFrequencyInMinute = value; }

        /// <summary>Backing field for <see cref="CrashConsistentFrequencyInMinute" /> property.</summary>
        private int? _crashConsistentFrequencyInMinute;

        /// <summary>The crash consistent snapshot frequency (in minutes).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public int? CrashConsistentFrequencyInMinute { get => this._crashConsistentFrequencyInMinute; set => this._crashConsistentFrequencyInMinute = value; }

        /// <summary>Backing field for <see cref="MultiVMSyncStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SetMultiVMSyncStatus _multiVMSyncStatus;

        /// <summary>
        /// A value indicating whether multi-VM sync has to be enabled. Value should be 'Enabled' or 'Disabled'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SetMultiVMSyncStatus MultiVMSyncStatus { get => this._multiVMSyncStatus; set => this._multiVMSyncStatus = value; }

        /// <summary>Backing field for <see cref="PolicyName" /> property.</summary>
        private string _policyName;

        /// <summary>The protection profile input.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string PolicyName { get => this._policyName; set => this._policyName = value; }

        /// <summary>Backing field for <see cref="RecoveryPointHistory" /> property.</summary>
        private int? _recoveryPointHistory;

        /// <summary>The duration in minutes until which the recovery points need to be stored.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public int? RecoveryPointHistory { get => this._recoveryPointHistory; set => this._recoveryPointHistory = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string ResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionProfileCustomDetailsInternal)__protectionProfileCustomDetails).ResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionProfileCustomDetailsInternal)__protectionProfileCustomDetails).ResourceType = value ?? null; }

        /// <summary>Creates an new <see cref="NewProtectionProfile" /> instance.</summary>
        public NewProtectionProfile()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__protectionProfileCustomDetails), __protectionProfileCustomDetails);
            await eventListener.AssertObjectIsValid(nameof(__protectionProfileCustomDetails), __protectionProfileCustomDetails);
        }
    }
    /// New Protection profile input.
    public partial interface INewProtectionProfile :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionProfileCustomDetails
    {
        /// <summary>The app consistent snapshot frequency (in minutes).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The app consistent snapshot frequency (in minutes).",
        SerializedName = @"appConsistentFrequencyInMinutes",
        PossibleTypes = new [] { typeof(int) })]
        int? AppConsistentFrequencyInMinute { get; set; }
        /// <summary>The crash consistent snapshot frequency (in minutes).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The crash consistent snapshot frequency (in minutes).",
        SerializedName = @"crashConsistentFrequencyInMinutes",
        PossibleTypes = new [] { typeof(int) })]
        int? CrashConsistentFrequencyInMinute { get; set; }
        /// <summary>
        /// A value indicating whether multi-VM sync has to be enabled. Value should be 'Enabled' or 'Disabled'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"A value indicating whether multi-VM sync has to be enabled. Value should be 'Enabled' or 'Disabled'.",
        SerializedName = @"multiVmSyncStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SetMultiVMSyncStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SetMultiVMSyncStatus MultiVMSyncStatus { get; set; }
        /// <summary>The protection profile input.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The protection profile input.",
        SerializedName = @"policyName",
        PossibleTypes = new [] { typeof(string) })]
        string PolicyName { get; set; }
        /// <summary>The duration in minutes until which the recovery points need to be stored.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The duration in minutes until which the recovery points need to be stored.",
        SerializedName = @"recoveryPointHistory",
        PossibleTypes = new [] { typeof(int) })]
        int? RecoveryPointHistory { get; set; }

    }
    /// New Protection profile input.
    internal partial interface INewProtectionProfileInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionProfileCustomDetailsInternal
    {
        /// <summary>The app consistent snapshot frequency (in minutes).</summary>
        int? AppConsistentFrequencyInMinute { get; set; }
        /// <summary>The crash consistent snapshot frequency (in minutes).</summary>
        int? CrashConsistentFrequencyInMinute { get; set; }
        /// <summary>
        /// A value indicating whether multi-VM sync has to be enabled. Value should be 'Enabled' or 'Disabled'.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SetMultiVMSyncStatus MultiVMSyncStatus { get; set; }
        /// <summary>The protection profile input.</summary>
        string PolicyName { get; set; }
        /// <summary>The duration in minutes until which the recovery points need to be stored.</summary>
        int? RecoveryPointHistory { get; set; }

    }
}