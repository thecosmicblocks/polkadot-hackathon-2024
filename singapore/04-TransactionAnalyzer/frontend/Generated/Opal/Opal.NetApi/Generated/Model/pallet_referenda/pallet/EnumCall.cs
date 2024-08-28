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


namespace Opal.NetApi.Generated.Model.pallet_referenda.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> submit
        /// See [`Pallet::submit`].
        /// </summary>
        submit = 0,
        
        /// <summary>
        /// >> place_decision_deposit
        /// See [`Pallet::place_decision_deposit`].
        /// </summary>
        place_decision_deposit = 1,
        
        /// <summary>
        /// >> refund_decision_deposit
        /// See [`Pallet::refund_decision_deposit`].
        /// </summary>
        refund_decision_deposit = 2,
        
        /// <summary>
        /// >> cancel
        /// See [`Pallet::cancel`].
        /// </summary>
        cancel = 3,
        
        /// <summary>
        /// >> kill
        /// See [`Pallet::kill`].
        /// </summary>
        kill = 4,
        
        /// <summary>
        /// >> nudge_referendum
        /// See [`Pallet::nudge_referendum`].
        /// </summary>
        nudge_referendum = 5,
        
        /// <summary>
        /// >> one_fewer_deciding
        /// See [`Pallet::one_fewer_deciding`].
        /// </summary>
        one_fewer_deciding = 6,
        
        /// <summary>
        /// >> refund_submission_deposit
        /// See [`Pallet::refund_submission_deposit`].
        /// </summary>
        refund_submission_deposit = 7,
        
        /// <summary>
        /// >> set_metadata
        /// See [`Pallet::set_metadata`].
        /// </summary>
        set_metadata = 8,
    }
    
    /// <summary>
    /// >> 206 - Variant[pallet_referenda.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Opal.NetApi.Generated.Model.opal_runtime.EnumOriginCaller, Opal.NetApi.Generated.Model.frame_support.traits.preimages.EnumBounded, Opal.NetApi.Generated.Model.frame_support.traits.schedule.EnumDispatchTime>, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U32, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseOpt<Opal.NetApi.Generated.Model.primitive_types.H256>>>
    {
    }
}
