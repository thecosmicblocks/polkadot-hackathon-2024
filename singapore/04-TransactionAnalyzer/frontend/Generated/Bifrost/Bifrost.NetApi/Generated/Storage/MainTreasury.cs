//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Bifrost.NetApi.Generated.Storage
{
    
    
    /// <summary>
    /// >> TreasuryStorage
    /// </summary>
    public sealed class TreasuryStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> TreasuryStorage Constructor
        /// </summary>
        public TreasuryStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Treasury", "ProposalCount"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Treasury", "Proposals"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U32), typeof(Bifrost.NetApi.Generated.Model.pallet_treasury.Proposal)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Treasury", "Deactivated"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Treasury", "Approvals"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Bifrost.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT40)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Treasury", "SpendCount"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Treasury", "Spends"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U32), typeof(Bifrost.NetApi.Generated.Model.pallet_treasury.SpendStatus)));
        }
        
        /// <summary>
        /// >> ProposalCountParams
        ///  Number of proposals that have been made.
        /// </summary>
        public static string ProposalCountParams()
        {
            return RequestGenerator.GetStorage("Treasury", "ProposalCount", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> ProposalCountDefault
        /// Default value as hex string
        /// </summary>
        public static string ProposalCountDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> ProposalCount
        ///  Number of proposals that have been made.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> ProposalCount(string blockhash, CancellationToken token)
        {
            string parameters = TreasuryStorage.ProposalCountParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> ProposalsParams
        ///  Proposals that have been made.
        /// </summary>
        public static string ProposalsParams(Substrate.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("Treasury", "Proposals", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ProposalsDefault
        /// Default value as hex string
        /// </summary>
        public static string ProposalsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Proposals
        ///  Proposals that have been made.
        /// </summary>
        public async Task<Bifrost.NetApi.Generated.Model.pallet_treasury.Proposal> Proposals(Substrate.NetApi.Model.Types.Primitive.U32 key, string blockhash, CancellationToken token)
        {
            string parameters = TreasuryStorage.ProposalsParams(key);
            var result = await _client.GetStorageAsync<Bifrost.NetApi.Generated.Model.pallet_treasury.Proposal>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> DeactivatedParams
        ///  The amount which has been reported as inactive to Currency.
        /// </summary>
        public static string DeactivatedParams()
        {
            return RequestGenerator.GetStorage("Treasury", "Deactivated", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> DeactivatedDefault
        /// Default value as hex string
        /// </summary>
        public static string DeactivatedDefault()
        {
            return "0x00000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> Deactivated
        ///  The amount which has been reported as inactive to Currency.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U128> Deactivated(string blockhash, CancellationToken token)
        {
            string parameters = TreasuryStorage.DeactivatedParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U128>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> ApprovalsParams
        ///  Proposal indices that have been approved but not yet awarded.
        /// </summary>
        public static string ApprovalsParams()
        {
            return RequestGenerator.GetStorage("Treasury", "Approvals", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> ApprovalsDefault
        /// Default value as hex string
        /// </summary>
        public static string ApprovalsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Approvals
        ///  Proposal indices that have been approved but not yet awarded.
        /// </summary>
        public async Task<Bifrost.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT40> Approvals(string blockhash, CancellationToken token)
        {
            string parameters = TreasuryStorage.ApprovalsParams();
            var result = await _client.GetStorageAsync<Bifrost.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT40>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> SpendCountParams
        ///  The count of spends that have been made.
        /// </summary>
        public static string SpendCountParams()
        {
            return RequestGenerator.GetStorage("Treasury", "SpendCount", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> SpendCountDefault
        /// Default value as hex string
        /// </summary>
        public static string SpendCountDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> SpendCount
        ///  The count of spends that have been made.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> SpendCount(string blockhash, CancellationToken token)
        {
            string parameters = TreasuryStorage.SpendCountParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> SpendsParams
        ///  Spends that have been approved and being processed.
        /// </summary>
        public static string SpendsParams(Substrate.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("Treasury", "Spends", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> SpendsDefault
        /// Default value as hex string
        /// </summary>
        public static string SpendsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Spends
        ///  Spends that have been approved and being processed.
        /// </summary>
        public async Task<Bifrost.NetApi.Generated.Model.pallet_treasury.SpendStatus> Spends(Substrate.NetApi.Model.Types.Primitive.U32 key, string blockhash, CancellationToken token)
        {
            string parameters = TreasuryStorage.SpendsParams(key);
            var result = await _client.GetStorageAsync<Bifrost.NetApi.Generated.Model.pallet_treasury.SpendStatus>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> TreasuryCalls
    /// </summary>
    public sealed class TreasuryCalls
    {
        
        /// <summary>
        /// >> propose_spend
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method ProposeSpend(Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> value, Bifrost.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress beneficiary)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(value.Encode());
            byteArray.AddRange(beneficiary.Encode());
            return new Method(61, "Treasury", 0, "propose_spend", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> reject_proposal
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method RejectProposal(Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> proposal_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(proposal_id.Encode());
            return new Method(61, "Treasury", 1, "reject_proposal", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> approve_proposal
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method ApproveProposal(Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> proposal_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(proposal_id.Encode());
            return new Method(61, "Treasury", 2, "approve_proposal", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> spend_local
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SpendLocal(Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> amount, Bifrost.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress beneficiary)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(amount.Encode());
            byteArray.AddRange(beneficiary.Encode());
            return new Method(61, "Treasury", 3, "spend_local", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_approval
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method RemoveApproval(Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> proposal_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(proposal_id.Encode());
            return new Method(61, "Treasury", 4, "remove_approval", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> spend
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Spend(Substrate.NetApi.Model.Types.Base.BaseTuple asset_kind, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> amount, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32 beneficiary, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> valid_from)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(asset_kind.Encode());
            byteArray.AddRange(amount.Encode());
            byteArray.AddRange(beneficiary.Encode());
            byteArray.AddRange(valid_from.Encode());
            return new Method(61, "Treasury", 5, "spend", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> payout
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Payout(Substrate.NetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(index.Encode());
            return new Method(61, "Treasury", 6, "payout", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> check_status
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method CheckStatus(Substrate.NetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(index.Encode());
            return new Method(61, "Treasury", 7, "check_status", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> void_spend
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method VoidSpend(Substrate.NetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(index.Encode());
            return new Method(61, "Treasury", 8, "void_spend", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> TreasuryConstants
    /// </summary>
    public sealed class TreasuryConstants
    {
        
        /// <summary>
        /// >> ProposalBond
        ///  Fraction of a proposal's value that should be bonded in order to place the proposal.
        ///  An accepted proposal gets these back. A rejected proposal does not.
        /// </summary>
        public Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Permill ProposalBond()
        {
            var result = new Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Permill();
            result.Create("0x50C30000");
            return result;
        }
        
        /// <summary>
        /// >> ProposalBondMinimum
        ///  Minimum amount of funds that should be placed in a deposit for making a proposal.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 ProposalBondMinimum()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x00407A10F35A00000000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> ProposalBondMaximum
        ///  Maximum amount of funds that should be placed in a deposit for making a proposal.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128> ProposalBondMaximum()
        {
            var result = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>();
            result.Create("0x0100406352BFC601000000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> SpendPeriod
        ///  Period between successive spends.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 SpendPeriod()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0xC0A80000");
            return result;
        }
        
        /// <summary>
        /// >> Burn
        ///  Percentage of spare funds (if any) that are burnt per spend period.
        /// </summary>
        public Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Permill Burn()
        {
            var result = new Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Permill();
            result.Create("0x00000000");
            return result;
        }
        
        /// <summary>
        /// >> PalletId
        ///  The treasury's pallet id, used for deriving its sovereign account ID.
        /// </summary>
        public Bifrost.NetApi.Generated.Model.frame_support.PalletId PalletId()
        {
            var result = new Bifrost.NetApi.Generated.Model.frame_support.PalletId();
            result.Create("0x62662F7472737279");
            return result;
        }
        
        /// <summary>
        /// >> MaxApprovals
        ///  The maximum number of approvals that can wait in the spending queue.
        /// 
        ///  NOTE: This parameter is also used within the Bounties Pallet extension if enabled.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxApprovals()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x64000000");
            return result;
        }
        
        /// <summary>
        /// >> PayoutPeriod
        ///  The period during which an approved treasury spend has to be claimed.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 PayoutPeriod()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0xC04B0300");
            return result;
        }
    }
    
    /// <summary>
    /// >> TreasuryErrors
    /// </summary>
    public enum TreasuryErrors
    {
        
        /// <summary>
        /// >> InsufficientProposersBalance
        /// Proposer's balance is too low.
        /// </summary>
        InsufficientProposersBalance,
        
        /// <summary>
        /// >> InvalidIndex
        /// No proposal, bounty or spend at that index.
        /// </summary>
        InvalidIndex,
        
        /// <summary>
        /// >> TooManyApprovals
        /// Too many approvals in the queue.
        /// </summary>
        TooManyApprovals,
        
        /// <summary>
        /// >> InsufficientPermission
        /// The spend origin is valid but the amount it is allowed to spend is lower than the
        /// amount to be spent.
        /// </summary>
        InsufficientPermission,
        
        /// <summary>
        /// >> ProposalNotApproved
        /// Proposal has not been approved.
        /// </summary>
        ProposalNotApproved,
        
        /// <summary>
        /// >> FailedToConvertBalance
        /// The balance of the asset kind is not convertible to the balance of the native asset.
        /// </summary>
        FailedToConvertBalance,
        
        /// <summary>
        /// >> SpendExpired
        /// The spend has expired and cannot be claimed.
        /// </summary>
        SpendExpired,
        
        /// <summary>
        /// >> EarlyPayout
        /// The spend is not yet eligible for payout.
        /// </summary>
        EarlyPayout,
        
        /// <summary>
        /// >> AlreadyAttempted
        /// The payment has already been attempted.
        /// </summary>
        AlreadyAttempted,
        
        /// <summary>
        /// >> PayoutError
        /// There was some issue with the mechanism of payment.
        /// </summary>
        PayoutError,
        
        /// <summary>
        /// >> NotAttempted
        /// The payout was not yet attempted/claimed.
        /// </summary>
        NotAttempted,
        
        /// <summary>
        /// >> Inconclusive
        /// The payment has neither failed nor succeeded yet.
        /// </summary>
        Inconclusive,
    }
}
