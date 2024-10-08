// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>The properties of a run argument.</summary>
    public partial class Argument :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IArgument,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IArgumentInternal
    {

        /// <summary>Backing field for <see cref="IsSecret" /> property.</summary>
        private bool? _isSecret;

        /// <summary>
        /// Flag to indicate whether the argument represents a secret and want to be removed from build logs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public bool? IsSecret { get => this._isSecret; set => this._isSecret = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the argument.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        /// <summary>The value of the argument.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="Argument" /> instance.</summary>
        public Argument()
        {

        }
    }
    /// The properties of a run argument.
    public partial interface IArgument :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Flag to indicate whether the argument represents a secret and want to be removed from build logs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to indicate whether the argument represents a secret and want to be removed from build logs.",
        SerializedName = @"isSecret",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsSecret { get; set; }
        /// <summary>The name of the argument.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the argument.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The value of the argument.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The value of the argument.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string Value { get; set; }

    }
    /// The properties of a run argument.
    internal partial interface IArgumentInternal

    {
        /// <summary>
        /// Flag to indicate whether the argument represents a secret and want to be removed from build logs.
        /// </summary>
        bool? IsSecret { get; set; }
        /// <summary>The name of the argument.</summary>
        string Name { get; set; }
        /// <summary>The value of the argument.</summary>
        string Value { get; set; }

    }
}