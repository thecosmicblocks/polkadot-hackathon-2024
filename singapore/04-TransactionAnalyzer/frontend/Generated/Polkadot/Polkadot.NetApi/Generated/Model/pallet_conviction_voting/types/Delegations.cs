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


namespace Polkadot.NetApi.Generated.Model.pallet_conviction_voting.types
{
    
    
    /// <summary>
    /// >> 640 - Composite[pallet_conviction_voting.types.Delegations]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Delegations : BaseType
    {
        
        /// <summary>
        /// >> votes
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Votes { get; set; }
        /// <summary>
        /// >> capital
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Capital { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Delegations";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Votes.Encode());
            result.AddRange(Capital.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Votes = new Substrate.NetApi.Model.Types.Primitive.U128();
            Votes.Decode(byteArray, ref p);
            Capital = new Substrate.NetApi.Model.Types.Primitive.U128();
            Capital.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
