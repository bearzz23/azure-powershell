// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    /// <summary>
    /// Set the minimum TLS version to be permitted on requests to storage. The default interpretation is TLS 1.0 for this property.
    /// </summary>
    public partial struct MinimumTlsVersion :
        System.IEquatable<MinimumTlsVersion>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.MinimumTlsVersion Tls10 = @"TLS1_0";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.MinimumTlsVersion Tls11 = @"TLS1_1";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.MinimumTlsVersion Tls12 = @"TLS1_2";

        /// <summary>the value for an instance of the <see cref="MinimumTlsVersion" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to MinimumTlsVersion</summary>
        /// <param name="value">the value to convert to an instance of <see cref="MinimumTlsVersion" />.</param>
        internal static object CreateFrom(object value)
        {
            return new MinimumTlsVersion(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type MinimumTlsVersion</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.MinimumTlsVersion e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type MinimumTlsVersion (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is MinimumTlsVersion && Equals((MinimumTlsVersion)obj);
        }

        /// <summary>Returns hashCode for enum MinimumTlsVersion</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="MinimumTlsVersion"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private MinimumTlsVersion(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for MinimumTlsVersion</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to MinimumTlsVersion</summary>
        /// <param name="value">the value to convert to an instance of <see cref="MinimumTlsVersion" />.</param>

        public static implicit operator MinimumTlsVersion(string value)
        {
            return new MinimumTlsVersion(value);
        }

        /// <summary>Implicit operator to convert MinimumTlsVersion to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="MinimumTlsVersion" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.MinimumTlsVersion e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum MinimumTlsVersion</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.MinimumTlsVersion e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.MinimumTlsVersion e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum MinimumTlsVersion</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.MinimumTlsVersion e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.MinimumTlsVersion e2)
        {
            return e2.Equals(e1);
        }
    }
}