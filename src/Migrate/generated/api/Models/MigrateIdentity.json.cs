// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    public partial class MigrateIdentity
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentity.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentity.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.IMigrateIdentity FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json ? new MigrateIdentity(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject into a new instance of <see cref="MigrateIdentity" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MigrateIdentity(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_subscriptionId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("subscriptionId"), out var __jsonSubscriptionId) ? (string)__jsonSubscriptionId : (string)SubscriptionId;}
            {_resourceGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("resourceGroupName"), out var __jsonResourceGroupName) ? (string)__jsonResourceGroupName : (string)ResourceGroupName;}
            {_siteName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("siteName"), out var __jsonSiteName) ? (string)__jsonSiteName : (string)SiteName;}
            {_clusterName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("clusterName"), out var __jsonClusterName) ? (string)__jsonClusterName : (string)ClusterName;}
            {_hostName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("hostName"), out var __jsonHostName) ? (string)__jsonHostName : (string)HostName;}
            {_jobName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("jobName"), out var __jsonJobName) ? (string)__jsonJobName : (string)JobName;}
            {_machineName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("machineName"), out var __jsonMachineName) ? (string)__jsonMachineName : (string)MachineName;}
            {_operationStatusName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("operationStatusName"), out var __jsonOperationStatusName) ? (string)__jsonOperationStatusName : (string)OperationStatusName;}
            {_accountName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("accountName"), out var __jsonAccountName) ? (string)__jsonAccountName : (string)AccountName;}
            {_migrateProjectName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("migrateProjectName"), out var __jsonMigrateProjectName) ? (string)__jsonMigrateProjectName : (string)MigrateProjectName;}
            {_vcenterName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("vcenterName"), out var __jsonVcenterName) ? (string)__jsonVcenterName : (string)VcenterName;}
            {_databaseInstanceName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("databaseInstanceName"), out var __jsonDatabaseInstanceName) ? (string)__jsonDatabaseInstanceName : (string)DatabaseInstanceName;}
            {_databaseName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("databaseName"), out var __jsonDatabaseName) ? (string)__jsonDatabaseName : (string)DatabaseName;}
            {_eventName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("eventName"), out var __jsonEventName) ? (string)__jsonEventName : (string)EventName;}
            {_solutionName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("solutionName"), out var __jsonSolutionName) ? (string)__jsonSolutionName : (string)SolutionName;}
            {_resourceName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("resourceName"), out var __jsonResourceName) ? (string)__jsonResourceName : (string)ResourceName;}
            {_alertSettingName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("alertSettingName"), out var __jsonAlertSettingName) ? (string)__jsonAlertSettingName : (string)AlertSettingName;}
            {_virtualMachineName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("virtualMachineName"), out var __jsonVirtualMachineName) ? (string)__jsonVirtualMachineName : (string)VirtualMachineName;}
            {_fabricName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("fabricName"), out var __jsonFabricName) ? (string)__jsonFabricName : (string)FabricName;}
            {_logicalNetworkName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("logicalNetworkName"), out var __jsonLogicalNetworkName) ? (string)__jsonLogicalNetworkName : (string)LogicalNetworkName;}
            {_networkName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("networkName"), out var __jsonNetworkName) ? (string)__jsonNetworkName : (string)NetworkName;}
            {_networkMappingName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("networkMappingName"), out var __jsonNetworkMappingName) ? (string)__jsonNetworkMappingName : (string)NetworkMappingName;}
            {_protectionContainerName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("protectionContainerName"), out var __jsonProtectionContainerName) ? (string)__jsonProtectionContainerName : (string)ProtectionContainerName;}
            {_migrationItemName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("migrationItemName"), out var __jsonMigrationItemName) ? (string)__jsonMigrationItemName : (string)MigrationItemName;}
            {_migrationRecoveryPointName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("migrationRecoveryPointName"), out var __jsonMigrationRecoveryPointName) ? (string)__jsonMigrationRecoveryPointName : (string)MigrationRecoveryPointName;}
            {_protectableItemName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("protectableItemName"), out var __jsonProtectableItemName) ? (string)__jsonProtectableItemName : (string)ProtectableItemName;}
            {_replicatedProtectedItemName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("replicatedProtectedItemName"), out var __jsonReplicatedProtectedItemName) ? (string)__jsonReplicatedProtectedItemName : (string)ReplicatedProtectedItemName;}
            {_replicationProtectedItemName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("replicationProtectedItemName"), out var __jsonReplicationProtectedItemName) ? (string)__jsonReplicationProtectedItemName : (string)ReplicationProtectedItemName;}
            {_recoveryPointName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("recoveryPointName"), out var __jsonRecoveryPointName) ? (string)__jsonRecoveryPointName : (string)RecoveryPointName;}
            {_mappingName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("mappingName"), out var __jsonMappingName) ? (string)__jsonMappingName : (string)MappingName;}
            {_providerName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("providerName"), out var __jsonProviderName) ? (string)__jsonProviderName : (string)ProviderName;}
            {_storageClassificationName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("storageClassificationName"), out var __jsonStorageClassificationName) ? (string)__jsonStorageClassificationName : (string)StorageClassificationName;}
            {_storageClassificationMappingName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("storageClassificationMappingName"), out var __jsonStorageClassificationMappingName) ? (string)__jsonStorageClassificationMappingName : (string)StorageClassificationMappingName;}
            {_policyName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("policyName"), out var __jsonPolicyName) ? (string)__jsonPolicyName : (string)PolicyName;}
            {_intentObjectName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("intentObjectName"), out var __jsonIntentObjectName) ? (string)__jsonIntentObjectName : (string)IntentObjectName;}
            {_recoveryPlanName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("recoveryPlanName"), out var __jsonRecoveryPlanName) ? (string)__jsonRecoveryPlanName : (string)RecoveryPlanName;}
            {_vaultSettingName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("vaultSettingName"), out var __jsonVaultSettingName) ? (string)__jsonVaultSettingName : (string)VaultSettingName;}
            {_id = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)Id;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="MigrateIdentity" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MigrateIdentity" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._subscriptionId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._subscriptionId.ToString()) : null, "subscriptionId" ,container.Add );
            AddIf( null != (((object)this._resourceGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._resourceGroupName.ToString()) : null, "resourceGroupName" ,container.Add );
            AddIf( null != (((object)this._siteName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._siteName.ToString()) : null, "siteName" ,container.Add );
            AddIf( null != (((object)this._clusterName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._clusterName.ToString()) : null, "clusterName" ,container.Add );
            AddIf( null != (((object)this._hostName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._hostName.ToString()) : null, "hostName" ,container.Add );
            AddIf( null != (((object)this._jobName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._jobName.ToString()) : null, "jobName" ,container.Add );
            AddIf( null != (((object)this._machineName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._machineName.ToString()) : null, "machineName" ,container.Add );
            AddIf( null != (((object)this._operationStatusName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._operationStatusName.ToString()) : null, "operationStatusName" ,container.Add );
            AddIf( null != (((object)this._accountName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._accountName.ToString()) : null, "accountName" ,container.Add );
            AddIf( null != (((object)this._migrateProjectName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._migrateProjectName.ToString()) : null, "migrateProjectName" ,container.Add );
            AddIf( null != (((object)this._vcenterName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._vcenterName.ToString()) : null, "vcenterName" ,container.Add );
            AddIf( null != (((object)this._databaseInstanceName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._databaseInstanceName.ToString()) : null, "databaseInstanceName" ,container.Add );
            AddIf( null != (((object)this._databaseName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._databaseName.ToString()) : null, "databaseName" ,container.Add );
            AddIf( null != (((object)this._eventName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._eventName.ToString()) : null, "eventName" ,container.Add );
            AddIf( null != (((object)this._solutionName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._solutionName.ToString()) : null, "solutionName" ,container.Add );
            AddIf( null != (((object)this._resourceName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._resourceName.ToString()) : null, "resourceName" ,container.Add );
            AddIf( null != (((object)this._alertSettingName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._alertSettingName.ToString()) : null, "alertSettingName" ,container.Add );
            AddIf( null != (((object)this._virtualMachineName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._virtualMachineName.ToString()) : null, "virtualMachineName" ,container.Add );
            AddIf( null != (((object)this._fabricName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._fabricName.ToString()) : null, "fabricName" ,container.Add );
            AddIf( null != (((object)this._logicalNetworkName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._logicalNetworkName.ToString()) : null, "logicalNetworkName" ,container.Add );
            AddIf( null != (((object)this._networkName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._networkName.ToString()) : null, "networkName" ,container.Add );
            AddIf( null != (((object)this._networkMappingName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._networkMappingName.ToString()) : null, "networkMappingName" ,container.Add );
            AddIf( null != (((object)this._protectionContainerName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._protectionContainerName.ToString()) : null, "protectionContainerName" ,container.Add );
            AddIf( null != (((object)this._migrationItemName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._migrationItemName.ToString()) : null, "migrationItemName" ,container.Add );
            AddIf( null != (((object)this._migrationRecoveryPointName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._migrationRecoveryPointName.ToString()) : null, "migrationRecoveryPointName" ,container.Add );
            AddIf( null != (((object)this._protectableItemName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._protectableItemName.ToString()) : null, "protectableItemName" ,container.Add );
            AddIf( null != (((object)this._replicatedProtectedItemName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._replicatedProtectedItemName.ToString()) : null, "replicatedProtectedItemName" ,container.Add );
            AddIf( null != (((object)this._replicationProtectedItemName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._replicationProtectedItemName.ToString()) : null, "replicationProtectedItemName" ,container.Add );
            AddIf( null != (((object)this._recoveryPointName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._recoveryPointName.ToString()) : null, "recoveryPointName" ,container.Add );
            AddIf( null != (((object)this._mappingName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._mappingName.ToString()) : null, "mappingName" ,container.Add );
            AddIf( null != (((object)this._providerName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._providerName.ToString()) : null, "providerName" ,container.Add );
            AddIf( null != (((object)this._storageClassificationName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._storageClassificationName.ToString()) : null, "storageClassificationName" ,container.Add );
            AddIf( null != (((object)this._storageClassificationMappingName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._storageClassificationMappingName.ToString()) : null, "storageClassificationMappingName" ,container.Add );
            AddIf( null != (((object)this._policyName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._policyName.ToString()) : null, "policyName" ,container.Add );
            AddIf( null != (((object)this._intentObjectName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._intentObjectName.ToString()) : null, "intentObjectName" ,container.Add );
            AddIf( null != (((object)this._recoveryPlanName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._recoveryPlanName.ToString()) : null, "recoveryPlanName" ,container.Add );
            AddIf( null != (((object)this._vaultSettingName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._vaultSettingName.ToString()) : null, "vaultSettingName" ,container.Add );
            AddIf( null != (((object)this._id)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._id.ToString()) : null, "id" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}