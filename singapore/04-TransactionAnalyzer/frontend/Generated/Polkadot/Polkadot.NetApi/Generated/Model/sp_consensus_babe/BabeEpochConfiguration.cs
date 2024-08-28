//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Polkadot.NetApi.Generated.Model.sp_consensus_babe
{
    
    
    /// <summary>
    /// >> 565 - Composite[sp_consensus_babe.BabeEpochConfiguration]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class BabeEpochConfiguration : BaseType
    {
        
        /// <summary>
        /// >> c
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, Substrate.NetApi.Model.Types.Primitive.U64> C { get; set; }
        /// <summary>
        /// >> allowed_slots
        /// </summary>
        public Polkadot.NetApi.Generated.Model.sp_consensus_babe.EnumAllowedSlots AllowedSlots { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "BabeEpochConfiguration";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(C.Encode());
            result.AddRange(AllowedSlots.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            C = new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, Substrate.NetApi.Model.Types.Primitive.U64>();
            C.Decode(byteArray, ref p);
            AllowedSlots = new Polkadot.NetApi.Generated.Model.sp_consensus_babe.EnumAllowedSlots();
            AllowedSlots.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
