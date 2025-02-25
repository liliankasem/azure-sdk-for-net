// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Disk input details. </summary>
    public partial class HyperVReplicaAzureDiskDetails
    {
        /// <summary> Initializes a new instance of HyperVReplicaAzureDiskDetails. </summary>
        public HyperVReplicaAzureDiskDetails()
        {
        }

        /// <summary> The DiskId. </summary>
        public string DiskId { get; set; }
        /// <summary> The LogStorageAccountId. </summary>
        public ResourceIdentifier LogStorageAccountId { get; set; }
        /// <summary> The DiskType. </summary>
        public SiteRecoveryDiskAccountType? DiskType { get; set; }
        /// <summary> The DiskEncryptionSet ARM ID. </summary>
        public ResourceIdentifier DiskEncryptionSetId { get; set; }
    }
}
