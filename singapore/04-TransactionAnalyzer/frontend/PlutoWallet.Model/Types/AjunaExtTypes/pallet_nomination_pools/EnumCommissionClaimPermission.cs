//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.NetApi.Generated.Model.pallet_nomination_pools
{
    
    
    /// <summary>
    /// >> CommissionClaimPermission
    /// </summary>
    public enum CommissionClaimPermission
    {
        
        /// <summary>
        /// >> Permissionless
        /// </summary>
        Permissionless = 0,
        
        /// <summary>
        /// >> Account
        /// </summary>
        Account = 1,
    }
    
    /// <summary>
    /// >> 318 - Variant[pallet_nomination_pools.CommissionClaimPermission]
    /// </summary>
    public sealed class EnumCommissionClaimPermission : BaseEnumExt<CommissionClaimPermission, BaseVoid, Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32>
    {
    }
}
