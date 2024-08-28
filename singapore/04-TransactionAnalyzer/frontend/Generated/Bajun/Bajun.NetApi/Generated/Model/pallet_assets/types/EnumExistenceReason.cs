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


namespace Bajun.NetApi.Generated.Model.pallet_assets.types
{
    
    
    /// <summary>
    /// >> ExistenceReason
    /// </summary>
    public enum ExistenceReason
    {
        
        /// <summary>
        /// >> Consumer
        /// </summary>
        Consumer = 0,
        
        /// <summary>
        /// >> Sufficient
        /// </summary>
        Sufficient = 1,
        
        /// <summary>
        /// >> DepositHeld
        /// </summary>
        DepositHeld = 2,
        
        /// <summary>
        /// >> DepositRefunded
        /// </summary>
        DepositRefunded = 3,
        
        /// <summary>
        /// >> DepositFrom
        /// </summary>
        DepositFrom = 4,
    }
    
    /// <summary>
    /// >> 659 - Variant[pallet_assets.types.ExistenceReason]
    /// </summary>
    public sealed class EnumExistenceReason : BaseEnumExt<ExistenceReason, BaseVoid, BaseVoid, Substrate.NetApi.Model.Types.Primitive.U128, BaseVoid, BaseTuple<Bajun.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>>
    {
    }
}
