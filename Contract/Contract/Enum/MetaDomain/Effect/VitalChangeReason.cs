#if NET9_0 
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.Enum.MetaDomain.Effect
{
#if NET9_0
    [ExportTsEnum(OutputDir = "enum/meta-domain/effect")]
#endif
    public enum VitalChangeReason
    {
        // Health - Restorative
        Heal,

        // Health - Offensive
        Critical,
        Damage,
        LifeSteal,

        // Health - Defensive
        Block,

        // Energy - Restorative
        EnergyRestore,

        // Energy - Offensive
        EnergyConsume,
    }
}