// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Storage
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// StorageAccountsOperations operations.
    /// </summary>
    public partial interface IStorageAccountsOperations
    {
        /// <summary>
        /// Checks that the storage account name is valid and is not already
        /// in use.
        /// </summary>
        /// <param name='name'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<CheckNameAvailabilityResult>> CheckNameAvailabilityWithHttpMessagesAsync(string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Asynchronously creates a new storage account with the specified
        /// parameters. If an account is already created and a subsequent
        /// create request is issued with different properties, the account
        /// properties will be updated. If an account is already created and
        /// a subsequent create or update request is issued with the exact
        /// same set of properties, the request will succeed.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters
        /// in length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='parameters'>
        /// The parameters to provide for the created account.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<StorageAccount>> CreateWithHttpMessagesAsync(string resourceGroupName, string accountName, StorageAccountCreateParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Asynchronously creates a new storage account with the specified
        /// parameters. If an account is already created and a subsequent
        /// create request is issued with different properties, the account
        /// properties will be updated. If an account is already created and
        /// a subsequent create or update request is issued with the exact
        /// same set of properties, the request will succeed.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters
        /// in length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='parameters'>
        /// The parameters to provide for the created account.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<StorageAccount>> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string accountName, StorageAccountCreateParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a storage account in Microsoft Azure.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters
        /// in length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the properties for the specified storage account including
        /// but not limited to name, SKU name, location, and account status.
        /// The ListKeys operation should be used to retrieve storage keys.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters
        /// in length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<StorageAccount>> GetPropertiesWithHttpMessagesAsync(string resourceGroupName, string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The update operation can be used to update the SKU, encryption,
        /// access tier, or tags for a storage account. It can also be used
        /// to map the account to a custom domain. Only one custom domain is
        /// supported per storage account; the replacement/change of custom
        /// domain is not supported. In order to replace an old custom
        /// domain, the old value must be cleared/unregistered before a new
        /// value can be set. The update of multiple properties is supported.
        /// This call does not change the storage keys for the account. If
        /// you want to change the storage account keys, use the regenerate
        /// keys operation. The location and name of the storage account
        /// cannot be changed after creation.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters
        /// in length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='parameters'>
        /// The parameters to provide for the updated account.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<StorageAccount>> UpdateWithHttpMessagesAsync(string resourceGroupName, string accountName, StorageAccountUpdateParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all the storage accounts available under the subscription.
        /// Note that storage keys are not returned; use the ListKeys
        /// operation for this.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IEnumerable<StorageAccount>>> ListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all the storage accounts available under the given resource
        /// group. Note that storage keys are not returned; use the ListKeys
        /// operation for this.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IEnumerable<StorageAccount>>> ListByResourceGroupWithHttpMessagesAsync(string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the access keys for the specified storage account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters
        /// in length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<StorageAccountListKeysResult>> ListKeysWithHttpMessagesAsync(string resourceGroupName, string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Regenerates one of the access keys for the specified storage
        /// account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters
        /// in length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='keyName'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<StorageAccountListKeysResult>> RegenerateKeyWithHttpMessagesAsync(string resourceGroupName, string accountName, string keyName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List SAS credentials of a storage account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters
        /// in length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='parameters'>
        /// The parameters to provide to list SAS credentials for the storage
        /// account.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ListAccountSasResponse>> ListAccountSasWithHttpMessagesAsync(string resourceGroupName, string accountName, AccountSasParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List service SAS credentials of a specific resource.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the user's subscription.
        /// </param>
        /// <param name='accountName'>
        /// The name of the storage account within the specified resource
        /// group. Storage account names must be between 3 and 24 characters
        /// in length and use numbers and lower-case letters only.
        /// </param>
        /// <param name='parameters'>
        /// The parameters to provide to list service SAS credentials.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ListServiceSasResponse>> ListServiceSasWithHttpMessagesAsync(string resourceGroupName, string accountName, ServiceSasParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
