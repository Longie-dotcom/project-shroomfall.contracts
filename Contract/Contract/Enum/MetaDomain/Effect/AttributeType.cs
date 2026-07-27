#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.Enum.MetaDomain.Effect
{
    /**
     * Architectural Categories & Pipeline Rules:
     * ──────────────────────────────────────────────────────────────────────────────────────────
     * 1. Vital Pool
     *    - Scope: Characteristic Only
     *    - Allowed Effect Types: N/A
     *    - Value Range: [0, Max]
     *    - Formula: See detail in code
     *
     * 2. Vital Delta
     *    - Scope: Effect Only
     *    - Allowed Effect Types: Flat, Percentage
     *    - Value Range: [0, ∞)
     *    - Formula: See detail in code
     *
     * 3. Core Scalable
     *    - Scope: Characteristic & Effect
     *    - Allowed Effect Types: Flat, Percentage
     *    - Value Range: Flat: (-∞, ∞), Percentage: [-1.0, 1.0]
     *    - Formula: (Base + Sum(Flat)) * (1 + Sum(Percentage))
     *
     * 4. Core Rate Signed
     *    - Scope: Characteristic & Effect
     *    - Allowed Effect Types: Flat Only
     *    - Value Range: [-1.0, 1.0]
     *    - Formula: Clamp(Base + Sum(Flat), -1.0, 1.0)
     *
     * 5. Core Rate Strict
     *    - Scope: Characteristic & Effect
     *    - Allowed Effect Types: Flat Only
     *    - Value Range: [0.0, 1.0]
     *    - Formula: Clamp(Base + Sum(Flat), 0.0, 1.0)
     * ──────────────────────────────────────────────────────────────────────────────────────────
     */
#if NET9_0
    [ExportTsEnum(OutputDir = "enum/meta-domain/effect")]
#endif
    public enum AttributeType
    {
        // ============================================================
        // Category: Vital Pool
        // ============================================================

        /// <summary>Category: Vital Pool</summary> 0
        Health,

        /// <summary>Category: Vital Pool</summary> 1
        Energy,

        // ============================================================
        // Category: Vital Delta
        // ============================================================

        /// <summary>Category: Vital Delta</summary> 2
        EnergyRestore,

        /// <summary>Category: Vital Delta</summary> 3
        EnergyConsume,

        /// <summary>Category: Vital Delta</summary> 4
        HealthRestore,

        /// <summary>Category: Vital Delta</summary> 5
        PhysicalDamage,

        /// <summary>Category: Vital Delta</summary> 6
        FireDamage,

        /// <summary>Category: Vital Delta</summary> 7
        IceDamage,

        /// <summary>Category: Vital Delta</summary> 8
        EarthDamage,

        /// <summary>Category: Vital Delta</summary> 9
        DarkDamage,

        /// <summary>Category: Vital Delta</summary> 10
        LightDamage,

        // ============================================================
        // Category: Core Scalable
        // ============================================================

        /// <summary>Category: Core Scalable</summary> 11
        PhysicalPower,

        /// <summary>Category: Core Scalable</summary> 12
        FirePower,

        /// <summary>Category: Core Scalable</summary> 14-1
        IcePower,

        /// <summary>Category: Core Scalable</summary> 14
        EarthPower,

        /// <summary>Category: Core Scalable</summary> 15
        DarkPower,

        /// <summary>Category: Core Scalable</summary> 16
        LightPower,

        /// <summary>Category: Core Scalable</summary> 17
        MoveSpeed,

        // ============================================================
        // Category: Core Rate Signed
        // ============================================================

        /// <summary>Category: Core Rate Signed</summary> 18
        PhysicalPenetration,

        /// <summary>Category: Core Rate Signed</summary> 19
        FirePenetration,

        /// <summary>Category: Core Rate Signed</summary> 20
        IcePenetration,

        /// <summary>Category: Core Rate Signed</summary> 21
        EarthPenetration,

        /// <summary>Category: Core Rate Signed</summary> 22
        DarkPenetration,

        /// <summary>Category: Core Rate Signed</summary> 23
        LightPenetration,

        /// <summary>Category: Core Rate Signed</summary> 24
        PhysicalResistance,

        /// <summary>Category: Core Rate Signed</summary> 25
        FireResistance,

        /// <summary>Category: Core Rate Signed</summary> 26
        IceResistance,

        /// <summary>Category: Core Rate Signed</summary> 27
        EarthResistance,

        /// <summary>Category: Core Rate Signed</summary> 28
        DarkResistance,

        /// <summary>Category: Core Rate Signed</summary> 29
        LightResistance,

        /// <summary>Category: Core Rate Signed</summary> 30
        CooldownReduction,

        /// <summary>Category: Core Rate Signed</summary> 31
        Lucky,

        // ============================================================
        // Category: Core Rate Strict
        // ============================================================

        /// <summary>Category: Core Rate Strict</summary> 32
        LifeSteal,

        /// <summary>Category: Core Rate Strict</summary> 33
        CriticalChance,

        /// <summary>Category: Core Rate Strict</summary> 34
        BlockChance,
    }
}