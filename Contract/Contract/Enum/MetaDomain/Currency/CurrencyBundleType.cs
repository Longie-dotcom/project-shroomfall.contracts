#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.Enum.MetaDomain.Currency
{
#if NET9_0
    [ExportTsEnum(OutputDir = "enum/meta-domain/currency")]
#endif
    // Decides which bundle image the frontend renders; bundles share these 4 images.
    public enum CurrencyBundleType
    {
        Small,
        Medium,
        Large,
        Huge
    }
}
