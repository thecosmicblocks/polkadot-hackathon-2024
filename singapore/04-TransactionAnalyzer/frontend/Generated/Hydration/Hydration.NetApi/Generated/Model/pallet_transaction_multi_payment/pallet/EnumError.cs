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


namespace Hydration.NetApi.Generated.Model.pallet_transaction_multi_payment.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> UnsupportedCurrency
        /// Selected currency is not supported.
        /// </summary>
        UnsupportedCurrency = 0,
        
        /// <summary>
        /// >> ZeroBalance
        /// Account balance should be non-zero.
        /// </summary>
        ZeroBalance = 1,
        
        /// <summary>
        /// >> AlreadyAccepted
        /// Currency is already in the list of accepted currencies.
        /// </summary>
        AlreadyAccepted = 2,
        
        /// <summary>
        /// >> CoreAssetNotAllowed
        /// It is not allowed to add Core Asset as accepted currency. Core asset is accepted by design.
        /// </summary>
        CoreAssetNotAllowed = 3,
        
        /// <summary>
        /// >> ZeroPrice
        /// Fallback price cannot be zero.
        /// </summary>
        ZeroPrice = 4,
        
        /// <summary>
        /// >> FallbackPriceNotFound
        /// Fallback price was not found.
        /// </summary>
        FallbackPriceNotFound = 5,
        
        /// <summary>
        /// >> Overflow
        /// Math overflow
        /// </summary>
        Overflow = 6,
        
        /// <summary>
        /// >> EvmAccountNotAllowed
        /// It is not allowed to change payment currency of an EVM account.
        /// </summary>
        EvmAccountNotAllowed = 7,
        
        /// <summary>
        /// >> EvmPermitExpired
        /// EVM permit expired.
        /// </summary>
        EvmPermitExpired = 8,
        
        /// <summary>
        /// >> EvmPermitInvalid
        /// EVM permit is invalid.
        /// </summary>
        EvmPermitInvalid = 9,
        
        /// <summary>
        /// >> EvmPermitCallExecutionError
        /// EVM permit call failed.
        /// </summary>
        EvmPermitCallExecutionError = 10,
        
        /// <summary>
        /// >> EvmPermitRunnerError
        /// EVM permit call failed.
        /// </summary>
        EvmPermitRunnerError = 11,
    }
    
    /// <summary>
    /// >> 277 - Variant[pallet_transaction_multi_payment.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
