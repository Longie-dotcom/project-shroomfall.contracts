#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.Enum.MetaDomain.Effect
{
    /**
     * Convention:
     * - Attributes marked as "Characteristic Only" exist exclusively on
     *   CharacteristicInstance.
     * - Attributes marked as "Effect Only" exist exclusively on EffectDefinition.
     *
     * Design:
     * - Domain groups attributes that share the same application pipeline.
     * - Category defines the role of an attribute within its domain.
     *
     * - Vital Domain:
     *   - Target attributes are the characteristics being modified.
     *   - Offensive and Restorative attributes are effect attributes that are
     *     translated into updates for their corresponding target attributes.
     *
     * - Core Domain:
     *   - Attributes are supporting characteristics used to resolve Vital
     *     effects (e.g. Power, Penetration, Resistance, LifeSteal).
     */

#if NET9_0
    [ExportTsEnum(OutputDir = "enum/meta-domain/effect")]
#endif
    public enum AttributeType
    {
        // ============================================================
        // Domain: Vital
        // ============================================================

        // Target - Energy - Characteristic Only
        Health,

        // Target - Health - Characteristic Only
        Energy,

        // Restorative - Energy - Effect Only
        EnergyRestore,

        // Offensive - Energy - Effect Only
        EnergyConsume,

        // Restorative - Health - Effect Only
        HealthRestore,

        // Offensive - Health - Effect Only
        PhysicalDamage,
        FireDamage,
        IceDamage,
        EarthDamage,
        DarkDamage,
        LightDamage,

        // ============================================================
        // Domain: Core
        // ============================================================

        // Offensive Support - Health
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
        CriticalChance,

        // Defensive Support - Health
        PhysicalResistance,
        FireResistance,
        IceResistance,
        EarthResistance,
        DarkResistance,
        LightResistance,

        BlockChance,

        // Utility
        MoveSpeed,
        CooldownReduction,
        Lucky,
    }
}