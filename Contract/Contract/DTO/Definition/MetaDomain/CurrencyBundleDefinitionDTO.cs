using System;
using Contract.Enum.MetaDomain.Currency;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Definition.MetaDomain
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/meta-domain")]
#endif
    public class CurrencyBundleDefinitionDTO
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public CurrencyBundleType Type { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ExpiredAt { get; set; }
    }
}
