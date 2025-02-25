// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Authorization
{
    /// <summary>
    /// A class representing a collection of <see cref="RoleManagementPolicyResource" /> and their operations.
    /// Each <see cref="RoleManagementPolicyResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get a <see cref="RoleManagementPolicyCollection" /> instance call the GetRoleManagementPolicies method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class RoleManagementPolicyCollection : ArmCollection, IEnumerable<RoleManagementPolicyResource>, IAsyncEnumerable<RoleManagementPolicyResource>
    {
        private readonly ClientDiagnostics _roleManagementPolicyClientDiagnostics;
        private readonly RoleManagementPoliciesRestOperations _roleManagementPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="RoleManagementPolicyCollection"/> class for mocking. </summary>
        protected RoleManagementPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RoleManagementPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RoleManagementPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _roleManagementPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Authorization", RoleManagementPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RoleManagementPolicyResource.ResourceType, out string roleManagementPolicyApiVersion);
            _roleManagementPolicyRestClient = new RoleManagementPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, roleManagementPolicyApiVersion);
        }

        /// <summary>
        /// Get the specified role management policy for a resource scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleManagementPolicies/{roleManagementPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleManagementPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleManagementPolicyName"> The name (guid) of the role management policy to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleManagementPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleManagementPolicyName"/> is null. </exception>
        public virtual async Task<Response<RoleManagementPolicyResource>> GetAsync(string roleManagementPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleManagementPolicyName, nameof(roleManagementPolicyName));

            using var scope = _roleManagementPolicyClientDiagnostics.CreateScope("RoleManagementPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _roleManagementPolicyRestClient.GetAsync(Id, roleManagementPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleManagementPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified role management policy for a resource scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleManagementPolicies/{roleManagementPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleManagementPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleManagementPolicyName"> The name (guid) of the role management policy to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleManagementPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleManagementPolicyName"/> is null. </exception>
        public virtual Response<RoleManagementPolicyResource> Get(string roleManagementPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleManagementPolicyName, nameof(roleManagementPolicyName));

            using var scope = _roleManagementPolicyClientDiagnostics.CreateScope("RoleManagementPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _roleManagementPolicyRestClient.Get(Id, roleManagementPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleManagementPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets role management policies for a resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleManagementPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleManagementPolicies_ListForScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RoleManagementPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RoleManagementPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _roleManagementPolicyRestClient.CreateListForScopeRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _roleManagementPolicyRestClient.CreateListForScopeNextPageRequest(nextLink, Id);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new RoleManagementPolicyResource(Client, RoleManagementPolicyData.DeserializeRoleManagementPolicyData(e)), _roleManagementPolicyClientDiagnostics, Pipeline, "RoleManagementPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets role management policies for a resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleManagementPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleManagementPolicies_ListForScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RoleManagementPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RoleManagementPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _roleManagementPolicyRestClient.CreateListForScopeRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _roleManagementPolicyRestClient.CreateListForScopeNextPageRequest(nextLink, Id);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new RoleManagementPolicyResource(Client, RoleManagementPolicyData.DeserializeRoleManagementPolicyData(e)), _roleManagementPolicyClientDiagnostics, Pipeline, "RoleManagementPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleManagementPolicies/{roleManagementPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleManagementPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleManagementPolicyName"> The name (guid) of the role management policy to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleManagementPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleManagementPolicyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string roleManagementPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleManagementPolicyName, nameof(roleManagementPolicyName));

            using var scope = _roleManagementPolicyClientDiagnostics.CreateScope("RoleManagementPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _roleManagementPolicyRestClient.GetAsync(Id, roleManagementPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleManagementPolicies/{roleManagementPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleManagementPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleManagementPolicyName"> The name (guid) of the role management policy to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleManagementPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleManagementPolicyName"/> is null. </exception>
        public virtual Response<bool> Exists(string roleManagementPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleManagementPolicyName, nameof(roleManagementPolicyName));

            using var scope = _roleManagementPolicyClientDiagnostics.CreateScope("RoleManagementPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _roleManagementPolicyRestClient.Get(Id, roleManagementPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RoleManagementPolicyResource> IEnumerable<RoleManagementPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RoleManagementPolicyResource> IAsyncEnumerable<RoleManagementPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
