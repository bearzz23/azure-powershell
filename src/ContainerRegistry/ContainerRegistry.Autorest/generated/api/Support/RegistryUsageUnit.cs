// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support
{

    /// <summary>The unit of measurement.</summary>
    public partial struct RegistryUsageUnit :
        System.IEquatable<RegistryUsageUnit>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.RegistryUsageUnit Bytes = @"Bytes";

        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.RegistryUsageUnit Count = @"Count";

        /// <summary>the value for an instance of the <see cref="RegistryUsageUnit" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to RegistryUsageUnit</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RegistryUsageUnit" />.</param>
        internal static object CreateFrom(object value)
        {
            return new RegistryUsageUnit(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type RegistryUsageUnit</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.RegistryUsageUnit e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type RegistryUsageUnit (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is RegistryUsageUnit && Equals((RegistryUsageUnit)obj);
        }

        /// <summary>Returns hashCode for enum RegistryUsageUnit</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="RegistryUsageUnit"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private RegistryUsageUnit(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for RegistryUsageUnit</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to RegistryUsageUnit</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RegistryUsageUnit" />.</param>

        public static implicit operator RegistryUsageUnit(string value)
        {
            return new RegistryUsageUnit(value);
        }

        /// <summary>Implicit operator to convert RegistryUsageUnit to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="RegistryUsageUnit" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.RegistryUsageUnit e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum RegistryUsageUnit</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.RegistryUsageUnit e1, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.RegistryUsageUnit e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum RegistryUsageUnit</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.RegistryUsageUnit e1, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.RegistryUsageUnit e2)
        {
            return e2.Equals(e1);
        }
    }
}