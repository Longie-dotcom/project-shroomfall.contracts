#if NET9_0 
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.Enum.MetaDomain.Effect
{
#if NET9_0
    [ExportTsEnum(OutputDir = "enum/meta-domain/effect")]
#endif
    public enum EffectType
    {
        // ─────────────────────────────
        // Flat value (direct number)
        // Example: Health = 100
        // ─────────────────────────────
        Flat,

        // ─────────────────────────────
        // Percentage-based value (0–100 or 0–1 depending design)
        // Example: CritChance = +10%
        // ─────────────────────────────
        Percentage,
    }
}
