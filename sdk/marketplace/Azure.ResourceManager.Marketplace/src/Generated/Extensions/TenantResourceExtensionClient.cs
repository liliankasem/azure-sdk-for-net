// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Marketplace
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    internal partial class TenantResourceExtensionClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="TenantResourceExtensionClient"/> class for mocking. </summary>
        protected TenantResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of PrivateStoreResources in the TenantResource. </summary>
        /// <returns> An object representing collection of PrivateStoreResources and their operations over a PrivateStoreResource. </returns>
        public virtual PrivateStoreCollection GetPrivateStores()
        {
            return GetCachedClient(Client => new PrivateStoreCollection(Client, Id));
        }
    }
}
