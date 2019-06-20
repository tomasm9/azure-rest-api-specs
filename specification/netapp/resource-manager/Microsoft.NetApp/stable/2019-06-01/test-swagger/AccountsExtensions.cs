// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Netapp
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Accounts.
    /// </summary>
    public static partial class AccountsExtensions
    {
            /// <summary>
            /// Describe all NetApp Accounts in a resource group
            /// </summary>
            /// <remarks>
            /// List and describe all NetApp accounts in the resource group
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static NetAppAccountList List(this IAccounts operations, string resourceGroupName)
            {
                return operations.ListAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Describe all NetApp Accounts in a resource group
            /// </summary>
            /// <remarks>
            /// List and describe all NetApp accounts in the resource group
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetAppAccountList> ListAsync(this IAccounts operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Describe a NetApp Account
            /// </summary>
            /// <remarks>
            /// Get the NetApp account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            public static NetAppAccount Get(this IAccounts operations, string resourceGroupName, string accountName)
            {
                return operations.GetAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Describe a NetApp Account
            /// </summary>
            /// <remarks>
            /// Get the NetApp account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetAppAccount> GetAsync(this IAccounts operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a NetApp account
            /// </summary>
            /// <remarks>
            /// Create or update the specified NetApp account within the resource group
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// NetApp Account object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            public static NetAppAccount CreateOrUpdate(this IAccounts operations, NetAppAccount body, string resourceGroupName, string accountName)
            {
                return operations.CreateOrUpdateAsync(body, resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a NetApp account
            /// </summary>
            /// <remarks>
            /// Create or update the specified NetApp account within the resource group
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// NetApp Account object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetAppAccount> CreateOrUpdateAsync(this IAccounts operations, NetAppAccount body, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(body, resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a NetApp account
            /// </summary>
            /// <remarks>
            /// Delete the specified NetApp account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            public static void Delete(this IAccounts operations, string resourceGroupName, string accountName)
            {
                operations.DeleteAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a NetApp account
            /// </summary>
            /// <remarks>
            /// Delete the specified NetApp account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IAccounts operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update a NetApp account
            /// </summary>
            /// <remarks>
            /// Patch the specified NetApp account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// NetApp Account object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            public static void Update(this IAccounts operations, NetAppAccountPatch body, string resourceGroupName, string accountName)
            {
                operations.UpdateAsync(body, resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a NetApp account
            /// </summary>
            /// <remarks>
            /// Patch the specified NetApp account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// NetApp Account object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this IAccounts operations, NetAppAccountPatch body, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(body, resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
