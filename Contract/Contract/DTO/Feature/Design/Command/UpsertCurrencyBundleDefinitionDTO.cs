using System;
using Contract.Enum.MetaDomain.Currency;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Feature.Design.Command
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/design/command")]
#endif
    public class UpsertCurrencyBundleDefinitionDTO
    {
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public CurrencyBundleType Type { get; set; }
        public DateTime ExpiredAt { get; set; }
    }
}
