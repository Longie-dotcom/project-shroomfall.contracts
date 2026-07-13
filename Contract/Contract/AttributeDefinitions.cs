using Contract.Enum.MetaDomain.Effect;
using System.Collections.Generic;

namespace Contract
{
    public static class AttributeLocalizationKeys
    {
        public const string AttackDamage = "attr_attack_damage";
        public const string FirePower = "attr_fire_power";
        public const string IcePower = "attr_ice_power";
        public const string EarthPower = "attr_earth_power";
        public const string DarkPower = "attr_dark_power";
        public const string LightPower = "attr_light_power";

        public const string DamageResistance = "attr_damage_resistance";
        public const string FireResistance = "attr_fire_resistance";
        public const string IceResistance = "attr_ice_resistance";
        public const string EarthResistance = "attr_earth_resistance";
        public const string DarkResistance = "attr_dark_resistance";
        public const string LightResistance = "attr_light_resistance";

        public const string MoveSpeed = "attr_move_speed";
        public const string Lucky = "attr_luck";
        public const string AttackSpeed = "attr_attack_speed";
        public const string AttackRange = "attr_attack_range";

        public const string Health = "attr_health";
        public const string Stamina = "attr_stamina";
        public const string Energy = "attr_energy";
    }

    public class AttributeDefinition
    {
        #region Attributes
        #endregion

        #region Properties
        public AttributeType Type { get; set; }
        public string LocalizationKey { get; set; } = string.Empty;
        public DomainType DomainType { get; set; }
        #endregion

        #region Methods
        #endregion
    }

    public static class AttributeDefinitions
    {
        private static readonly Dictionary<AttributeType, AttributeDefinition> map;

        static AttributeDefinitions()
        {
            map = new Dictionary<AttributeType, AttributeDefinition>
            {
                // ───────── Combat ─────────
                [AttributeType.AttackDamage] = CreateCore(AttributeType.AttackDamage, AttributeLocalizationKeys.AttackDamage),
                [AttributeType.FirePower] = CreateCore(AttributeType.FirePower, AttributeLocalizationKeys.FirePower),
                [AttributeType.IcePower] = CreateCore(AttributeType.IcePower, AttributeLocalizationKeys.IcePower),
                [AttributeType.EarthPower] = CreateCore(AttributeType.EarthPower, AttributeLocalizationKeys.EarthPower),
                [AttributeType.DarkPower] = CreateCore(AttributeType.DarkPower, AttributeLocalizationKeys.DarkPower),
                [AttributeType.LightPower] = CreateCore(AttributeType.LightPower, AttributeLocalizationKeys.LightPower),

                // ───────── Resistance ─────────
                [AttributeType.DamageResistance] = CreateCore(AttributeType.DamageResistance, AttributeLocalizationKeys.DamageResistance),
                [AttributeType.FireResistance] = CreateCore(AttributeType.FireResistance, AttributeLocalizationKeys.FireResistance),
                [AttributeType.IceResistance] = CreateCore(AttributeType.IceResistance, AttributeLocalizationKeys.IceResistance),
                [AttributeType.EarthResistance] = CreateCore(AttributeType.EarthResistance, AttributeLocalizationKeys.EarthResistance),
                [AttributeType.DarkResistance] = CreateCore(AttributeType.DarkResistance, AttributeLocalizationKeys.DarkResistance),
                [AttributeType.LightResistance] = CreateCore(AttributeType.LightResistance, AttributeLocalizationKeys.LightResistance),

                // ───────── Utility ─────────
                [AttributeType.MoveSpeed] = CreateCore(AttributeType.MoveSpeed, AttributeLocalizationKeys.MoveSpeed),
                [AttributeType.Lucky] = CreateCore(AttributeType.Lucky, AttributeLocalizationKeys.Lucky),
                [AttributeType.AttackSpeed] = CreateCore(AttributeType.AttackSpeed, AttributeLocalizationKeys.AttackSpeed),
                [AttributeType.AttackRange] = CreateCore(AttributeType.AttackRange, AttributeLocalizationKeys.AttackRange),

                // ───────── Vital ─────────
                [AttributeType.Health] = CreateVital(AttributeType.Health, AttributeLocalizationKeys.Health),
                [AttributeType.Stamina] = CreateVital(AttributeType.Stamina, AttributeLocalizationKeys.Stamina),
                [AttributeType.Energy] = CreateVital(AttributeType.Energy, AttributeLocalizationKeys.Energy),
            };
        }

        #region Helper Factory Methods
        private static AttributeDefinition CreateCore(AttributeType type, string keyName) =>
            Create(type, DomainType.Core, keyName);

        private static AttributeDefinition CreateVital(AttributeType type, string keyName) =>
            Create(type, DomainType.Vital, keyName);

        private static AttributeDefinition Create(
            AttributeType type,
            DomainType domainType,
            string localizationKey)
        {
            return new AttributeDefinition
            {
                Type = type,
                DomainType = domainType,
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