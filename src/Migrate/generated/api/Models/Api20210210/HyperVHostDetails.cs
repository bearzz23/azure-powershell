namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Hyper-V host details.</summary>
    public partial class HyperVHostDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVHostDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVHostDetailsInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The Hyper-V host Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Backing field for <see cref="MarsAgentVersion" /> property.</summary>
        private string _marsAgentVersion;

        /// <summary>The Mars agent version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string MarsAgentVersion { get => this._marsAgentVersion; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVHostDetailsInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for MarsAgentVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVHostDetailsInternal.MarsAgentVersion { get => this._marsAgentVersion; set { {_marsAgentVersion = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IHyperVHostDetailsInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The Hyper-V host name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Creates an new <see cref="HyperVHostDetails" /> instance.</summary>
        public HyperVHostDetails()
        {

        }
    }
    /// Hyper-V host details.
    public partial interface IHyperVHostDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The Hyper-V host Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Hyper-V host Id.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>The Mars agent version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Mars agent version.",
        SerializedName = @"marsAgentVersion",
        PossibleTypes = new [] { typeof(string) })]
        string MarsAgentVersion { get;  }
        /// <summary>The Hyper-V host name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Hyper-V host name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }

    }
    /// Hyper-V host details.
    internal partial interface IHyperVHostDetailsInternal

    {
        /// <summary>The Hyper-V host Id.</summary>
        string Id { get; set; }
        /// <summary>The Mars agent version.</summary>
        string MarsAgentVersion { get; set; }
        /// <summary>The Hyper-V host name.</summary>
        string Name { get; set; }

    }
}