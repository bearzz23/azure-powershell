// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Extensions;

    public partial class Error :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IError,
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IErrorInternal
    {

        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ErrorResponseCode? Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExtendedErrorInfoInternal)Error1).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExtendedErrorInfoInternal)Error1).Code = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ErrorResponseCode)""); }

        /// <summary>Backing field for <see cref="Error1" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExtendedErrorInfo _error1;

        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExtendedErrorInfo Error1 { get => (this._error1 = this._error1 ?? new Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ExtendedErrorInfo()); set => this._error1 = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExtendedErrorInfoInternal)Error1).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExtendedErrorInfoInternal)Error1).Message = value ?? null; }

        /// <summary>Internal Acessors for Error1</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExtendedErrorInfo Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IErrorInternal.Error1 { get => (this._error1 = this._error1 ?? new Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.ExtendedErrorInfo()); set { {_error1 = value;} } }

        /// <summary>Creates an new <see cref="Error" /> instance.</summary>
        public Error()
        {

        }
    }
    public partial interface IError :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ErrorResponseCode) })]
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ErrorResponseCode? Code { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }

    }
    internal partial interface IErrorInternal

    {
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.ErrorResponseCode? Code { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20220301.IExtendedErrorInfo Error1 { get; set; }

        string Message { get; set; }

    }
}