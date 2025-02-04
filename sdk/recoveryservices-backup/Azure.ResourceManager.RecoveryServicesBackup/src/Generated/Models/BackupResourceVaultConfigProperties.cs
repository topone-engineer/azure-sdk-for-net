// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.RecoveryServicesBackup;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Backup resource vault config details. </summary>
    public partial class BackupResourceVaultConfigProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BackupResourceVaultConfigProperties"/>. </summary>
        public BackupResourceVaultConfigProperties()
        {
            ResourceGuardOperationRequests = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="BackupResourceVaultConfigProperties"/>. </summary>
        /// <param name="storageModelType"> Storage type. </param>
        /// <param name="storageType"> Storage type. </param>
        /// <param name="storageTypeState"> Locked or Unlocked. Once a machine is registered against a resource, the storageTypeState is always Locked. </param>
        /// <param name="enhancedSecurityState"> Enabled or Disabled. </param>
        /// <param name="softDeleteFeatureState"> Soft Delete feature state. </param>
        /// <param name="softDeleteRetentionPeriodInDays"> Soft delete retention period in days. </param>
        /// <param name="resourceGuardOperationRequests"> ResourceGuard Operation Requests. </param>
        /// <param name="isSoftDeleteFeatureStateEditable"> This flag is no longer in use. Please use 'softDeleteFeatureState' to set the soft delete state for the vault. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BackupResourceVaultConfigProperties(BackupStorageType? storageModelType, BackupStorageType? storageType, BackupStorageTypeState? storageTypeState, EnhancedSecurityState? enhancedSecurityState, SoftDeleteFeatureState? softDeleteFeatureState, int? softDeleteRetentionPeriodInDays, IList<string> resourceGuardOperationRequests, bool? isSoftDeleteFeatureStateEditable, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StorageModelType = storageModelType;
            StorageType = storageType;
            StorageTypeState = storageTypeState;
            EnhancedSecurityState = enhancedSecurityState;
            SoftDeleteFeatureState = softDeleteFeatureState;
            SoftDeleteRetentionPeriodInDays = softDeleteRetentionPeriodInDays;
            ResourceGuardOperationRequests = resourceGuardOperationRequests;
            IsSoftDeleteFeatureStateEditable = isSoftDeleteFeatureStateEditable;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Storage type. </summary>
        public BackupStorageType? StorageModelType { get; set; }
        /// <summary> Storage type. </summary>
        public BackupStorageType? StorageType { get; set; }
        /// <summary> Locked or Unlocked. Once a machine is registered against a resource, the storageTypeState is always Locked. </summary>
        public BackupStorageTypeState? StorageTypeState { get; set; }
        /// <summary> Enabled or Disabled. </summary>
        public EnhancedSecurityState? EnhancedSecurityState { get; set; }
        /// <summary> Soft Delete feature state. </summary>
        public SoftDeleteFeatureState? SoftDeleteFeatureState { get; set; }
        /// <summary> Soft delete retention period in days. </summary>
        public int? SoftDeleteRetentionPeriodInDays { get; set; }
        /// <summary> ResourceGuard Operation Requests. </summary>
        public IList<string> ResourceGuardOperationRequests { get; }
        /// <summary> This flag is no longer in use. Please use 'softDeleteFeatureState' to set the soft delete state for the vault. </summary>
        public bool? IsSoftDeleteFeatureStateEditable { get; set; }
    }
}
