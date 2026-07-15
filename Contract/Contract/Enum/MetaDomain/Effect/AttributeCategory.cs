#if NET9_0 
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.Enum.MetaDomain.Effect
{
#if NET9_0
    [ExportTsEnum(OutputDir = "enum/meta-domain/effect")]
#endif
    public enum AttributeCategory
    {
        Health,
        Energy,
        OffensiveHealth,
        OffensiveEnergy,
        Defensive,
        Utility,
    }
}