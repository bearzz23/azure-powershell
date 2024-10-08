// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201
{
    using Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.PowerShell;

    /// <summary>The run operation result properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(OperationResultPropertiesTypeConverter))]
    public partial class OperationResultProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.OperationResultProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new OperationResultProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.OperationResultProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new OperationResultProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="OperationResultProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="OperationResultProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.OperationResultProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal OperationResultProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Correlation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).Correlation = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRunActionCorrelation) content.GetValueForProperty("Correlation",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).Correlation, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.RunActionCorrelationTypeConverter.ConvertFrom);
            }
            if (content.Contains("StartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).StartTime = (global::System.DateTime?) content.GetValueForProperty("StartTime",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).StartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("EndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).EndTime = (global::System.DateTime?) content.GetValueForProperty("EndTime",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).EndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.WorkflowStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.WorkflowStatus.CreateFrom);
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("CorrelationClientTrackingId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).CorrelationClientTrackingId = (string) content.GetValueForProperty("CorrelationClientTrackingId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).CorrelationClientTrackingId, global::System.Convert.ToString);
            }
            if (content.Contains("CorrelationClientKeyword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).CorrelationClientKeyword = (string[]) content.GetValueForProperty("CorrelationClientKeyword",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).CorrelationClientKeyword, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CorrelationActionTrackingId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).CorrelationActionTrackingId = (string) content.GetValueForProperty("CorrelationActionTrackingId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).CorrelationActionTrackingId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.OperationResultProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal OperationResultProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Correlation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).Correlation = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRunActionCorrelation) content.GetValueForProperty("Correlation",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).Correlation, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.RunActionCorrelationTypeConverter.ConvertFrom);
            }
            if (content.Contains("StartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).StartTime = (global::System.DateTime?) content.GetValueForProperty("StartTime",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).StartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("EndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).EndTime = (global::System.DateTime?) content.GetValueForProperty("EndTime",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).EndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.WorkflowStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.WorkflowStatus.CreateFrom);
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("CorrelationClientTrackingId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).CorrelationClientTrackingId = (string) content.GetValueForProperty("CorrelationClientTrackingId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).CorrelationClientTrackingId, global::System.Convert.ToString);
            }
            if (content.Contains("CorrelationClientKeyword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).CorrelationClientKeyword = (string[]) content.GetValueForProperty("CorrelationClientKeyword",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).CorrelationClientKeyword, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CorrelationActionTrackingId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).CorrelationActionTrackingId = (string) content.GetValueForProperty("CorrelationActionTrackingId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IOperationResultPropertiesInternal)this).CorrelationActionTrackingId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The run operation result properties.
    [System.ComponentModel.TypeConverter(typeof(OperationResultPropertiesTypeConverter))]
    public partial interface IOperationResultProperties

    {

    }
}