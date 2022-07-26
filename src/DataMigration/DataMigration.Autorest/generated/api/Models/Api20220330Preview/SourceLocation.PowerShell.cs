// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.PowerShell;

    /// <summary>Source Location details of backups.</summary>
    [System.ComponentModel.TypeConverter(typeof(SourceLocationTypeConverter))]
    public partial class SourceLocation
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
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.SourceLocation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocation"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocation DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SourceLocation(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.SourceLocation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocation"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocation DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SourceLocation(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SourceLocation" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SourceLocation" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocation FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.SourceLocation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SourceLocation(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("FileShare"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).FileShare = (Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISqlFileShare) content.GetValueForProperty("FileShare",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).FileShare, Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.SqlFileShareTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureBlob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).AzureBlob = (Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.IAzureBlob) content.GetValueForProperty("AzureBlob",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).AzureBlob, Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.AzureBlobTypeConverter.ConvertFrom);
            }
            if (content.Contains("FileStorageType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).FileStorageType = (string) content.GetValueForProperty("FileStorageType",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).FileStorageType, global::System.Convert.ToString);
            }
            if (content.Contains("AzureBlobAccountKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).AzureBlobAccountKey = (string) content.GetValueForProperty("AzureBlobAccountKey",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).AzureBlobAccountKey, global::System.Convert.ToString);
            }
            if (content.Contains("FileSharePath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).FileSharePath = (string) content.GetValueForProperty("FileSharePath",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).FileSharePath, global::System.Convert.ToString);
            }
            if (content.Contains("FileShareUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).FileShareUsername = (string) content.GetValueForProperty("FileShareUsername",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).FileShareUsername, global::System.Convert.ToString);
            }
            if (content.Contains("FileSharePassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).FileSharePassword = (System.Security.SecureString) content.GetValueForProperty("FileSharePassword",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).FileSharePassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("AzureBlobStorageAccountResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).AzureBlobStorageAccountResourceId = (string) content.GetValueForProperty("AzureBlobStorageAccountResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).AzureBlobStorageAccountResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("AzureBlobContainerName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).AzureBlobContainerName = (string) content.GetValueForProperty("AzureBlobContainerName",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).AzureBlobContainerName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.SourceLocation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SourceLocation(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("FileShare"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).FileShare = (Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISqlFileShare) content.GetValueForProperty("FileShare",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).FileShare, Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.SqlFileShareTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureBlob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).AzureBlob = (Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.IAzureBlob) content.GetValueForProperty("AzureBlob",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).AzureBlob, Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.AzureBlobTypeConverter.ConvertFrom);
            }
            if (content.Contains("FileStorageType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).FileStorageType = (string) content.GetValueForProperty("FileStorageType",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).FileStorageType, global::System.Convert.ToString);
            }
            if (content.Contains("AzureBlobAccountKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).AzureBlobAccountKey = (string) content.GetValueForProperty("AzureBlobAccountKey",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).AzureBlobAccountKey, global::System.Convert.ToString);
            }
            if (content.Contains("FileSharePath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).FileSharePath = (string) content.GetValueForProperty("FileSharePath",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).FileSharePath, global::System.Convert.ToString);
            }
            if (content.Contains("FileShareUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).FileShareUsername = (string) content.GetValueForProperty("FileShareUsername",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).FileShareUsername, global::System.Convert.ToString);
            }
            if (content.Contains("FileSharePassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).FileSharePassword = (System.Security.SecureString) content.GetValueForProperty("FileSharePassword",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).FileSharePassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("AzureBlobStorageAccountResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).AzureBlobStorageAccountResourceId = (string) content.GetValueForProperty("AzureBlobStorageAccountResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).AzureBlobStorageAccountResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("AzureBlobContainerName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).AzureBlobContainerName = (string) content.GetValueForProperty("AzureBlobContainerName",((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20220330Preview.ISourceLocationInternal)this).AzureBlobContainerName, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Source Location details of backups.
    [System.ComponentModel.TypeConverter(typeof(SourceLocationTypeConverter))]
    public partial interface ISourceLocation

    {

    }
}