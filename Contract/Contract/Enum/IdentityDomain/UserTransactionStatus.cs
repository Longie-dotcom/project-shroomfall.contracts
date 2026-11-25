#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.Enum.IdentityDomain
{
#if NET9_0
    [ExportTsEnum(OutputDir = "enum/identity-domain")]
#endif
    public enum UserTransactionStatus
    {
        Pending,    // Payment link created, not paid yet
        Paid,       // Payment webhook verified, currency not yet given to the player
        Credited,   // Game service confirmed the currency was added
        Cancelled   // Abandoned before payment
    }
}
