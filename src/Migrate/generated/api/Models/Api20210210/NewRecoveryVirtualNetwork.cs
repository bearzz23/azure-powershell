namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>
    /// Recovery virtual network input to create new virtual network from given source network.
    /// </summary>
    public partial class NewRecoveryVirtualNetwork :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INewRecoveryVirtualNetwork,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INewRecoveryVirtualNetworkInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryVirtualNetworkCustomDetails"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryVirtualNetworkCustomDetails __recoveryVirtualNetworkCustomDetails = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.RecoveryVirtualNetworkCustomDetails();

        /// <summary>Backing field for <see cref="RecoveryVirtualNetworkName" /> property.</summary>
        private string _recoveryVirtualNetworkName;

        /// <summary>The recovery virtual network name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryVirtualNetworkName { get => this._recoveryVirtualNetworkName; set => this._recoveryVirtualNetworkName = value; }

        /// <summary>
        /// Backing field for <see cref="RecoveryVirtualNetworkResourceGroupName" /> property.
        /// </summary>
        private string _recoveryVirtualNetworkResourceGroupName;

        /// <summary>
        /// The name of the resource group to be used to create the recovery virtual network. If absent, target network would be created
        /// in the same resource group as target VM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryVirtualNetworkResourceGroupName { get => this._recoveryVirtualNetworkResourceGroupName; set => this._recoveryVirtualNetworkResourceGroupName = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string ResourceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryVirtualNetworkCustomDetailsInternal)__recoveryVirtualNetworkCustomDetails).ResourceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryVirtualNetworkCustomDetailsInternal)__recoveryVirtualNetworkCustomDetails).ResourceType = value ?? null; }

        /// <summary>Creates an new <see cref="NewRecoveryVirtualNetwork" /> instance.</summary>
        public NewRecoveryVirtualNetwork()
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
    /// Recovery virtual network input to create new virtual network from given source network.
    public partial interface INewRecoveryVirtualNetwork :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryVirtualNetworkCustomDetails
    {
        /// <summary>The recovery virtual network name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The recovery virtual network name.",
        SerializedName = @"recoveryVirtualNetworkName",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryVirtualNetworkName { get; set; }
        /// <summary>
        /// The name of the resource group to be used to create the recovery virtual network. If absent, target network would be created
        /// in the same resource group as target VM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the resource group to be used to create the recovery virtual network. If absent, target network would be created in the same resource group as target VM.",
        SerializedName = @"recoveryVirtualNetworkResourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryVirtualNetworkResourceGroupName { get; set; }

    }
    /// Recovery virtual network input to create new virtual network from given source network.
    internal partial interface INewRecoveryVirtualNetworkInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IRecoveryVirtualNetworkCustomDetailsInternal
    {
        /// <summary>The recovery virtual network name.</summary>
        string RecoveryVirtualNetworkName { get; set; }
        /// <summary>
        /// The name of the resource group to be used to create the recovery virtual network. If absent, target network would be created
        /// in the same resource group as target VM.
        /// </summary>
        string RecoveryVirtualNetworkResourceGroupName { get; set; }

    }
}