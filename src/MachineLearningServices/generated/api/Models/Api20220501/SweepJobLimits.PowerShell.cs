// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501
{
    using Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.PowerShell;

    /// <summary>Sweep Job limit class.</summary>
    [System.ComponentModel.TypeConverter(typeof(SweepJobLimitsTypeConverter))]
    public partial class SweepJobLimits
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.SweepJobLimits"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISweepJobLimits"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISweepJobLimits DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SweepJobLimits(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.SweepJobLimits"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISweepJobLimits"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISweepJobLimits DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SweepJobLimits(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SweepJobLimits" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SweepJobLimits" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISweepJobLimits FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.SweepJobLimits"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SweepJobLimits(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MaxConcurrentTrial"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISweepJobLimitsInternal)this).MaxConcurrentTrial = (int?) content.GetValueForProperty("MaxConcurrentTrial",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISweepJobLimitsInternal)this).MaxConcurrentTrial, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("MaxTotalTrial"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISweepJobLimitsInternal)this).MaxTotalTrial = (int?) content.GetValueForProperty("MaxTotalTrial",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISweepJobLimitsInternal)this).MaxTotalTrial, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("TrialTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISweepJobLimitsInternal)this).TrialTimeout = (global::System.TimeSpan?) content.GetValueForProperty("TrialTimeout",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISweepJobLimitsInternal)this).TrialTimeout, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobLimitsInternal)this).Type = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobLimitsType) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobLimitsInternal)this).Type, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobLimitsType.CreateFrom);
            }
            if (content.Contains("Timeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobLimitsInternal)this).Timeout = (global::System.TimeSpan?) content.GetValueForProperty("Timeout",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobLimitsInternal)this).Timeout, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.SweepJobLimits"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SweepJobLimits(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MaxConcurrentTrial"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISweepJobLimitsInternal)this).MaxConcurrentTrial = (int?) content.GetValueForProperty("MaxConcurrentTrial",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISweepJobLimitsInternal)this).MaxConcurrentTrial, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("MaxTotalTrial"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISweepJobLimitsInternal)this).MaxTotalTrial = (int?) content.GetValueForProperty("MaxTotalTrial",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISweepJobLimitsInternal)this).MaxTotalTrial, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("TrialTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISweepJobLimitsInternal)this).TrialTimeout = (global::System.TimeSpan?) content.GetValueForProperty("TrialTimeout",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISweepJobLimitsInternal)this).TrialTimeout, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobLimitsInternal)this).Type = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobLimitsType) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobLimitsInternal)this).Type, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobLimitsType.CreateFrom);
            }
            if (content.Contains("Timeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobLimitsInternal)this).Timeout = (global::System.TimeSpan?) content.GetValueForProperty("Timeout",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobLimitsInternal)this).Timeout, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Sweep Job limit class.
    [System.ComponentModel.TypeConverter(typeof(SweepJobLimitsTypeConverter))]
    public partial interface ISweepJobLimits

    {

    }
}