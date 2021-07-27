namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Existing recovery virtual network input.</summary>
    public partial class ExistingRecoveryVirtualNetwork :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IExistingRecoveryVirtualNetwork,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IExistingRecoveryVirtualNetworkInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryVirtualNetworkCustomDetails"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryVirtualNetworkCustomDetails __recoveryVirtualNetworkCustomDetails = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryVirtualNetworkCustomDetails();

        /// <summary>Backing field for <see cref="RecoverySubnetName" /> property.</summary>
        private string _recoverySubnetName;

        /// <summary>The recovery subnet name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoverySubnetName { get => this._recoverySubnetName; set => this._recoverySubnetName = value; }

        /// <summary>Backing field for <see cref="RecoveryVirtualNetworkId" /> property.</summary>
        private string _recoveryVirtualNetworkId;

        /// <summary>The recovery virtual network Id. Will throw error, if resource does not exist.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryVirtualNetworkId { get => this._recoveryVirtualNetworkId; set => this._recoveryVirtualNetworkId = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string ResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryVirtualNetworkCustomDetailsInternal)__recoveryVirtualNetworkCustomDetails).ResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryVirtualNetworkCustomDetailsInternal)__recoveryVirtualNetworkCustomDetails).ResourceType = value ?? null; }

        /// <summary>Creates an new <see cref="ExistingRecoveryVirtualNetwork" /> instance.</summary>
        public ExistingRecoveryVirtualNetwork()
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
            await eventListener.AssertNotNull(nameof(__recoveryVirtualNetworkCustomDetails), __recoveryVirtualNetworkCustomDetails);
            await eventListener.AssertObjectIsValid(nameof(__recoveryVirtualNetworkCustomDetails), __recoveryVirtualNetworkCustomDetails);
        }
    }
    /// Existing recovery virtual network input.
    public partial interface IExistingRecoveryVirtualNetwork :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryVirtualNetworkCustomDetails
    {
        /// <summary>The recovery subnet name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The recovery subnet name.",
        SerializedName = @"recoverySubnetName",
        PossibleTypes = new [] { typeof(string) })]
        string RecoverySubnetName { get; set; }
        /// <summary>The recovery virtual network Id. Will throw error, if resource does not exist.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The recovery virtual network Id. Will throw error, if resource does not exist.",
        SerializedName = @"recoveryVirtualNetworkId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryVirtualNetworkId { get; set; }

    }
    /// Existing recovery virtual network input.
    internal partial interface IExistingRecoveryVirtualNetworkInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryVirtualNetworkCustomDetailsInternal
    {
        /// <summary>The recovery subnet name.</summary>
        string RecoverySubnetName { get; set; }
        /// <summary>The recovery virtual network Id. Will throw error, if resource does not exist.</summary>
        string RecoveryVirtualNetworkId { get; set; }

    }
}