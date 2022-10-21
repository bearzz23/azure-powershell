// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KeyVault.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AccessPolicyUpdateKind.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccessPolicyUpdateKind
    {
        [EnumMember(Value = "add")]
        Add,
        [EnumMember(Value = "replace")]
        Replace,
        [EnumMember(Value = "remove")]
        Remove
    }
    internal static class AccessPolicyUpdateKindEnumExtension
    {
        internal static string ToSerializedValue(this AccessPolicyUpdateKind? value)
        {
            return value == null ? null : ((AccessPolicyUpdateKind)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AccessPolicyUpdateKind value)
        {
            switch( value )
            {
                case AccessPolicyUpdateKind.Add:
                    return "add";
                case AccessPolicyUpdateKind.Replace:
                    return "replace";
                case AccessPolicyUpdateKind.Remove:
                    return "remove";
            }
            return null;
        }

        internal static AccessPolicyUpdateKind? ParseAccessPolicyUpdateKind(this string value)
        {
            switch( value )
            {
                case "add":
                    return AccessPolicyUpdateKind.Add;
                case "replace":
                    return AccessPolicyUpdateKind.Replace;
                case "remove":
                    return AccessPolicyUpdateKind.Remove;
            }
            return null;
        }
    }
}
