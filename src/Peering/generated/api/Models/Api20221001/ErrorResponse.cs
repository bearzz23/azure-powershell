// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Extensions;

    /// <summary>The error response that indicates why an operation has failed.</summary>
    public partial class ErrorResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IErrorResponse,
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IErrorResponseInternal
    {

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IErrorDetailInternal)Error).Code; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IErrorDetail _error;

        /// <summary>The error detail that describes why an operation has failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IErrorDetail Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.ErrorDetail()); set => this._error = value; }

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IErrorDetailInternal)Error).Message; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IErrorResponseInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IErrorDetailInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IErrorDetailInternal)Error).Code = value; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IErrorDetail Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IErrorResponseInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.ErrorDetail()); set { {_error = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IErrorResponseInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IErrorDetailInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IErrorDetailInternal)Error).Message = value; }

        /// <summary>Creates an new <see cref="ErrorResponse" /> instance.</summary>
        public ErrorResponse()
        {

        }
    }
    /// The error response that indicates why an operation has failed.
    public partial interface IErrorResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.IJsonSerializable
    {
        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }

    }
    /// The error response that indicates why an operation has failed.
    internal partial interface IErrorResponseInternal

    {
        /// <summary>The error code.</summary>
        string Code { get; set; }
        /// <summary>The error detail that describes why an operation has failed.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IErrorDetail Error { get; set; }
        /// <summary>The error message.</summary>
        string Message { get; set; }

    }
}