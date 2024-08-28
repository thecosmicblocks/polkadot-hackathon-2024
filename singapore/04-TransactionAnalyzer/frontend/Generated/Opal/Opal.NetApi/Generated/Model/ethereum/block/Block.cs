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


namespace Opal.NetApi.Generated.Model.ethereum.block
{
    
    
    /// <summary>
    /// >> 651 - Composite[ethereum.block.Block]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Block : BaseType
    {
        
        /// <summary>
        /// >> header
        /// </summary>
        public Opal.NetApi.Generated.Model.ethereum.header.Header Header { get; set; }
        /// <summary>
        /// >> transactions
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApi.Generated.Model.ethereum.transaction.EnumTransactionV2> Transactions { get; set; }
        /// <summary>
        /// >> ommers
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApi.Generated.Model.ethereum.header.Header> Ommers { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Block";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Header.Encode());
            result.AddRange(Transactions.Encode());
            result.AddRange(Ommers.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Header = new Opal.NetApi.Generated.Model.ethereum.header.Header();
            Header.Decode(byteArray, ref p);
            Transactions = new Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApi.Generated.Model.ethereum.transaction.EnumTransactionV2>();
            Transactions.Decode(byteArray, ref p);
            Ommers = new Substrate.NetApi.Model.Types.Base.BaseVec<Opal.NetApi.Generated.Model.ethereum.header.Header>();
            Ommers.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
