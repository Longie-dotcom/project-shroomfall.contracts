using Contract.Enum.MetaDomain.Effect;
using System.Collections.Generic;

namespace Contract
{
    public static class AttributeLocalizationKeys
    {
        // ============================================================
        // Domain: Vital
        // ============================================================

        // Target - Health
        public const string Health = "attr_health";

        // Target - Energy
        public const string Energy = "attr_energy";

        // Restorative - Health
        public const string HealthRestore = "attr_health_restore";

        // Restorative - Energy
        public const string EnergyRestore = "attr_energy_restore";

        // Offensive - Health
        public const string PhysicalDamage = "attr_physical_damage";
        public const string FireDamage = "attr_fire_damage";
        public const string IceDamage = "attr_ice_damage";
        public const string EarthDamage = "attr_earth_damage";
        public const string DarkDamage = "attr_dark_damage";
        public const string LightDamage = "attr_light_damage";

        // Offensive - Energy
        public const string EnergyConsume = "attr_energy_consume";

        // ============================================================
        // Domain: Core
        // ============================================================

        // Offensive Support - Health
        public const string PhysicalPower = "attr_physical_power";
        public const string FirePower = "attr_fire_power";
        public const string IcePower = "attr_ice_power";
        public const string EarthPower = "attr_earth_power";
        public const string DarkPower = "attr_dark_power";
        public const string LightPower = "attr_light_power";

        public const string PhysicalPenetration = "attr_physical_penetration";
        public const string FirePenetration = "attr_fire_penetration";
        public const string IcePenetration = "attr_ice_penetration";
        public const string EarthPenetration = "attr_earth_penetration";
        public const string DarkPenetration = "attr_dark_penetration";
        public const string LightPenetration = "attr_light_penetration";

        public const string LifeSteal = "attr_life_steal";
        public const string CriticalChance = "attr_critical_chance";

        // Defensive Support - Health
        public const string PhysicalResistance = "attr_physical_resistance";
        public const string FireResistance = "attr_fire_resistance";
        public const string IceResistance = "attr_ice_resistance";
        public const string EarthResistance = "attr_earth_resistance";
        public const string DarkResistance = "attr_dark_resistance";
        public const string LightResistance = "attr_light_resistance";

        public const string BlockChance = "attr_block_chance";

        // Utility
        public const string MoveSpeed = "attr_move_speed";
        public const string CooldownReduction = "attr_cooldown_reduction";
        public const string Lucky = "attr_lucky";
    }

    public class AttributeDefinition
    {
        public AttributeType Type { get; set; }
        public string LocalizationKey { get; set; } = string.Empty;
        public DomainType DomainType { get; set; } // Storage
        public AttributeCategory Category { get; set; } // Semantic usage
    }

    public static class AttributeDefinitions
    {
        private static readonly Dictionary<AttributeType, AttributeDefinition> map;

        static AttributeDefinitions()
        {
            map = new Dictionary<AttributeType, AttributeDefinition>
            {
                // ============================================================
                // Domain: Vital
                // ============================================================

                // Target - Health
                [AttributeType.Health] = CreateVital(
                AttributeType.Health,
                AttributeCategory.TargetHealth,
                AttributeLocalizationKeys.Health),

                // Target - Energy
                [AttributeType.Energy] = CreateVital(
                AttributeType.Energy,
                AttributeCategory.TargetEnergy,
                AttributeLocalizationKeys.Energy),

                // Restorative - Health
                [AttributeType.HealthRestore] = CreateVital(
                AttributeType.HealthRestore,
                AttributeCategory.RestorativeHealth,
                AttributeLocalizationKeys.HealthRestore),

                // Restorative - Energy
                [AttributeType.EnergyRestore] = CreateVital(
                AttributeType.EnergyRestore,
                AttributeCategory.RestorativeEnergy,
                AttributeLocalizationKeys.EnergyRestore),

                // Offensive - Health
                [AttributeType.PhysicalDamage] = CreateVital(
                AttributeType.PhysicalDamage,
                AttributeCategory.OffensiveHealth,
                AttributeLocalizationKeys.PhysicalDamage),

                [AttributeType.FireDamage] = CreateVital(
                AttributeType.FireDamage,
                AttributeCategory.OffensiveHealth,
                AttributeLocalizationKeys.FireDamage),

                [AttributeType.IceDamage] = CreateVital(
                AttributeType.IceDamage,
                AttributeCategory.OffensiveHealth,
                AttributeLocalizationKeys.IceDamage),

                [AttributeType.EarthDamage] = CreateVital(
                AttributeType.EarthDamage,
                AttributeCategory.OffensiveHealth,
                AttributeLocalizationKeys.EarthDamage),

                [AttributeType.DarkDamage] = CreateVital(
                AttributeType.DarkDamage,
                AttributeCategory.OffensiveHealth,
                AttributeLocalizationKeys.DarkDamage),

                [AttributeType.LightDamage] = CreateVital(
                AttributeType.LightDamage,
                AttributeCategory.OffensiveHealth,
                AttributeLocalizationKeys.LightDamage),

                // Offensive - Energy
                [AttributeType.EnergyConsume] = CreateVital(
                AttributeType.EnergyConsume,
                AttributeCategory.OffensiveEnergy,
                AttributeLocalizationKeys.EnergyConsume),

                // ============================================================
                // Domain: Core
                // ============================================================

                // Offensive Support - Health
                [AttributeType.PhysicalPower] = CreateCore(
                AttributeType.PhysicalPower,
                AttributeCategory.OffensiveHealth,
                AttributeLocalizationKeys.PhysicalPower),

                [AttributeType.FirePower] = CreateCore(
                AttributeType.FirePower,
                AttributeCategory.OffensiveHealth,
                AttributeLocalizationKeys.FirePower),

                [AttributeType.IcePower] = CreateCore(
                AttributeType.IcePower,
                AttributeCategory.OffensiveHealth,
                AttributeLocalizationKeys.IcePower),

                [AttributeType.EarthPower] = CreateCore(
                AttributeType.EarthPower,
                AttributeCategory.OffensiveHealth,
                AttributeLocalizationKeys.EarthPower),

                [AttributeType.DarkPower] = CreateCore(
                AttributeType.DarkPower,
                AttributeCategory.OffensiveHealth,
                AttributeLocalizationKeys.DarkPower),

                [AttributeType.LightPower] = CreateCore(
                AttributeType.LightPower,
                AttributeCategory.OffensiveHealth,
                AttributeLocalizationKeys.LightPower),

                [AttributeType.PhysicalPenetration] = CreateCore(
                AttributeType.PhysicalPenetration,
                AttributeCategory.OffensiveHealth,
                AttributeLocalizationKeys.PhysicalPenetration),

                [AttributeType.FirePenetration] = CreateCore(
                AttributeType.FirePenetration,
                AttributeCategory.OffensiveHealth,
                AttributeLocalizationKeys.FirePenetration),

                [AttributeType.IcePenetration] = CreateCore(
                AttributeType.IcePenetration,
                AttributeCategory.OffensiveHealth,
                AttributeLocalizationKeys.IcePenetration),

                [AttributeType.EarthPenetration] = CreateCore(
                AttributeType.EarthPenetration,
                AttributeCategory.OffensiveHealth,
                AttributeLocalizationKeys.EarthPenetration),

                [AttributeType.DarkPenetration] = CreateCore(
                AttributeType.DarkPenetration,
                AttributeCategory.OffensiveHealth,
                AttributeLocalizationKeys.DarkPenetration),

                [AttributeType.LightPenetration] = CreateCore(
                AttributeType.LightPenetration,
                AttributeCategory.OffensiveHealth,
                AttributeLocalizationKeys.LightPenetration),

                [AttributeType.LifeSteal] = CreateCore(
                AttributeType.LifeSteal,
                AttributeCategory.OffensiveHealth,
                AttributeLocalizationKeys.LifeSteal),

                [AttributeType.CriticalChance] = CreateCore(
                AttributeType.CriticalChance,
                AttributeCategory.OffensiveHealth,
                AttributeLocalizationKeys.CriticalChance),

                // Defensive Support - Health
                [AttributeType.PhysicalResistance] = CreateCore(
                AttributeType.PhysicalResistance,
                AttributeCategory.DefensiveHealth,
                AttributeLocalizationKeys.PhysicalResistance),

                [AttributeType.FireResistance] = CreateCore(
                AttributeType.FireResistance,
                AttributeCategory.DefensiveHealth,
                AttributeLocalizationKeys.FireResistance),

                [AttributeType.IceResistance] = CreateCore(
                AttributeType.IceResistance,
                AttributeCategory.DefensiveHealth,
                AttributeLocalizationKeys.IceResistance),

                [AttributeType.EarthResistance] = CreateCore(
                AttributeType.EarthResistance,
                AttributeCategory.DefensiveHealth,
                AttributeLocalizationKeys.EarthResistance),

                [AttributeType.DarkResistance] = CreateCore(
                AttributeType.DarkResistance,
                AttributeCategory.DefensiveHealth,
                AttributeLocalizationKeys.DarkResistance),

                [AttributeType.LightResistance] = CreateCore(
                AttributeType.LightResistance,
                AttributeCategory.DefensiveHealth,
                AttributeLocalizationKeys.LightResistance),

                [AttributeType.BlockChance] = CreateCore(
                AttributeType.BlockChance,
                AttributeCategory.DefensiveHealth,
                AttributeLocalizationKeys.BlockChance),

                // Utility
                [AttributeType.MoveSpeed] = CreateCore(
                AttributeType.MoveSpeed,
                AttributeCategory.Utility,
                AttributeLocalizationKeys.MoveSpeed),

                [AttributeType.CooldownReduction] = CreateCore(
                AttributeType.CooldownReduction,
                AttributeCategory.Utility,
                AttributeLocalizationKeys.CooldownReduction),

                [AttributeType.Lucky] = CreateCore(
                AttributeType.Lucky,
                AttributeCategory.Utility,
                AttributeLocalizationKeys.Lucky),
            };
        }

        #region Helper Factory Methods
        private static AttributeDefinition CreateCore(
            AttributeType type,
            AttributeCategory category,
            string localizationKey)
        {
            return Create(type, DomainType.Core, category, localizationKey);
        }

        private static AttributeDefinition CreateVital(
            AttributeType type,
            AttributeCategory category,
            string localizationKey)
        {
            return Create(type, DomainType.Vital, category, localizationKey);
        }

        private static AttributeDefinition Create(
            AttributeType type,
            DomainType domainType,
            AttributeCategory category,
            string localizationKey)
        {
            return new AttributeDefinition
            {
                Type = type,
                DomainType = domainType,
                Category = category,
                LocalizationKey = localizationKey
            };
        }
        #endregion

        #region Queries
        public static AttributeDefinition Get(
            AttributeType parameter)
        {
            return map[parameter];
        }

        public static bool TryGet(
            AttributeType parameter, 
            out AttributeDefinition definition)
        {
            return map.TryGetValue(parameter, out definition!);
        }

        public static IReadOnlyDictionary<AttributeType, AttributeDefinition> All()
        {
            return map;
        }

        public static IEnumerable<AttributeDefinition> AllList()
        {
            return map.Values;
        }
        #endregion
    }
}