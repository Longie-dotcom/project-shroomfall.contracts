#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Feature.Payment.Response
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/payment/response")]
#endif
    public class CurrencyBundlePaymentDTO
    {
        public long OrderCode { get; set; }
        // Frontend redirects the player here to pay.
        public string CheckoutUrl { get; set; } = string.Empty;
    }
}
