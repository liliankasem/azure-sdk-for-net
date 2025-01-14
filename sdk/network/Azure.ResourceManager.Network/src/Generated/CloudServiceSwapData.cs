// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the CloudServiceSwap data model.
    /// SwapResource to represent slot type on the specified cloud service.
    /// </summary>
    public partial class CloudServiceSwapData : ResourceData
    {
        /// <summary> Initializes a new instance of CloudServiceSwapData. </summary>
        public CloudServiceSwapData()
        {
        }

        /// <summary> Initializes a new instance of CloudServiceSwapData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Swap resource properties. </param>
        internal CloudServiceSwapData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, CloudServiceSwapProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Swap resource properties. </summary>
        internal CloudServiceSwapProperties Properties { get; set; }
        /// <summary> Specifies slot info on a cloud service. </summary>
        public SwapSlotType? CloudServiceSwapSlotType
        {
            get => Properties is null ? default : Properties.SlotType;
            set
            {
                if (Properties is null)
                    Properties = new CloudServiceSwapProperties();
                Properties.SlotType = value;
            }
        }
    }
}
