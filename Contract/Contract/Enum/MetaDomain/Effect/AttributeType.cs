#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.Enum.MetaDomain.Effect
{
#if NET9_0
    [ExportTsEnum(OutputDir = "enum/meta-domain/effect")]
#endif
    public enum AttributeType
    {
        // ============================================================
        // Domain: Vital
        // ============================================================

        Health,
        Energy,

        // Offensive
        PhysicalDamage,
        FireDamage,
        IceDamage,
        EarthDamage,
        DarkDamage,
        LightDamage,

        // ============================================================
        // Domain: Core
        // ============================================================

        // Offensive
        PhysicalPower,
        FirePower,
        IcePower,
        EarthPower,
        DarkPower,
        LightPower,

        PhysicalPenetration,
        FirePenetration,
        IcePenetration,
        EarthPenetration,
        DarkPenetration,
        LightPenetration,

        LifeSteal,

        // Defensive
        PhysicalResistance,
        FireResistance,
        IceResistance,
        EarthResistance,
        DarkResistance,
        LightResistance,

        BlockChance,

        // Utility
        MoveSpeed,
        CriticalChance,
        CooldownReduction,
        Lucky,
    }
}