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
        // ───────── Combat ─────────
        AttackDamage,
        FirePower,
        IcePower,
        EarthPower,
        DarkPower,
        LightPower,

        // ───────── Resistance ─────────
        DamageResistance,
        FireResistance,
        IceResistance,
        EarthResistance,
        DarkResistance,
        LightResistance,

        // ───────── Utility ─────────
        MoveSpeed,
        AttackSpeed,
        AttackRange,
        Lucky,

        // ───────── Vital System ─────────
        Health,
        Stamina,
        Energy,
    }
}
