using Contract.Enum.IdentityDomain;
using System;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Definition.IdentityDomain
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/identity-domain")]
#endif
    public class UserTransactionDTO
    {
        public long ID { get; set; }
        public long OrderCode { get; set; }
#if NET9_0
        [TsOptional]
#endif
        public string? PaymentLinkID { get; set; }
        public UserTransactionStatus Status { get; set; }
        public string UserID { get; set; } = string.Empty;
        public string CurrencyBundleDefinitionID { get; set; } = string.Empty;
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
