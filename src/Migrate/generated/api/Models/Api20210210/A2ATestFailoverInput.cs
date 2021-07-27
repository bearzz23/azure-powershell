namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>A2A provider specific input for test failover.</summary>
    public partial class A2ATestFailoverInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ATestFailoverInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ATestFailoverInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverProviderSpecificInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverProviderSpecificInput __testFailoverProviderSpecificInput = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.TestFailoverProviderSpecificInput();

        /// <summary>Backing field for <see cref="CloudServiceCreationOption" /> property.</summary>
        private string _cloudServiceCreationOption;

        /// <summary>A value indicating whether to use recovery cloud service for TFO or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string CloudServiceCreationOption { get => this._cloudServiceCreationOption; set => this._cloudServiceCreationOption = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverProviderSpecificInputInternal)__testFailoverProviderSpecificInput).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverProviderSpecificInputInternal)__testFailoverProviderSpecificInput).InstanceType = value ?? null; }

        /// <summary>Backing field for <see cref="RecoveryPointId" /> property.</summary>
        private string _recoveryPointId;

        /// <summary>
        /// The recovery point id to be passed to test failover to a particular recovery point. In case of latest recovery point,
        /// null should be passed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryPointId { get => this._recoveryPointId; set => this._recoveryPointId = value; }

        /// <summary>Creates an new <see cref="A2ATestFailoverInput" /> instance.</summary>
        public A2ATestFailoverInput()
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
            await eventListener.AssertNotNull(nameof(__testFailoverProviderSpecificInput), __testFailoverProviderSpecificInput);
            await eventListener.AssertObjectIsValid(nameof(__testFailoverProviderSpecificInput), __testFailoverProviderSpecificInput);
        }
    }
    /// A2A provider specific input for test failover.
    public partial interface IA2ATestFailoverInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverProviderSpecificInput
    {
        /// <summary>A value indicating whether to use recovery cloud service for TFO or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether to use recovery cloud service for TFO or not.",
        SerializedName = @"cloudServiceCreationOption",
        PossibleTypes = new [] { typeof(string) })]
        string CloudServiceCreationOption { get; set; }
        /// <summary>
        /// The recovery point id to be passed to test failover to a particular recovery point. In case of latest recovery point,
        /// null should be passed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The recovery point id to be passed to test failover to a particular recovery point. In case of latest recovery point, null should be passed.",
        SerializedName = @"recoveryPointId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryPointId { get; set; }

    }
    /// A2A provider specific input for test failover.
    internal partial interface IA2ATestFailoverInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.ITestFailoverProviderSpecificInputInternal
    {
        /// <summary>A value indicating whether to use recovery cloud service for TFO or not.</summary>
        string CloudServiceCreationOption { get; set; }
        /// <summary>
        /// The recovery point id to be passed to test failover to a particular recovery point. In case of latest recovery point,
        /// null should be passed.
        /// </summary>
        string RecoveryPointId { get; set; }

    }
}