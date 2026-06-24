#if NET9_0 
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.Enum.MetaDomain.Effect
{
#if NET9_0
    [ExportTsEnum(OutputDir = "enums/meta/effect")]
#endif
    public enum DomainType
    {
        Core,        // attack, defense, movement
        Vital,       // health, stamina, energy
    }
}