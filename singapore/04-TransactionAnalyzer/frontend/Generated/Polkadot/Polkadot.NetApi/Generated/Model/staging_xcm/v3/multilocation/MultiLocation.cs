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


namespace Polkadot.NetApi.Generated.Model.staging_xcm.v3.multilocation
{
    
    
    /// <summary>
    /// >> 66 - Composite[staging_xcm.v3.multilocation.MultiLocation]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class MultiLocation : BaseType
    {
        
        /// <summary>
        /// >> parents
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U8 Parents { get; set; }
        /// <summary>
        /// >> interior
        /// </summary>
        public Polkadot.NetApi.Generated.Model.xcm.v3.junctions.EnumJunctions Interior { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "MultiLocation";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Parents.Encode());
            result.AddRange(Interior.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Parents = new Substrate.NetApi.Model.Types.Primitive.U8();
            Parents.Decode(byteArray, ref p);
            Interior = new Polkadot.NetApi.Generated.Model.xcm.v3.junctions.EnumJunctions();
            Interior.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
