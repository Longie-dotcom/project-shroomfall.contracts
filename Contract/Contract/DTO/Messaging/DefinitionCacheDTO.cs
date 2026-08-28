using Contract.DTO.Definition.EntityDomain.Component;
using Contract.DTO.Definition.LocalizationDomain;
using Contract.DTO.Definition.MetaDomain;
using Contract.DTO.Definition.WorldDomain;
using System.Collections.Generic;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Messaging
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/messaging")]
#endif
    public class DefinitionCacheDTO
    {
        public long Version { get; set; }

        public List<EffectDefinitionDTO> Effects { get; set; } = new List<EffectDefinitionDTO>();
        public List<ItemDefinitionDTO> Items { get; set; } = new List<ItemDefinitionDTO>();


        public List<AIDefinitionDTO> AIs { get; set; } = new List<AIDefinitionDTO>();
        public List<AppearanceDefinitionDTO> Appearances { get; set; } = new List<AppearanceDefinitionDTO>();
        public List<CollisionDefinitionDTO> Collisions { get; set; } = new List<CollisionDefinitionDTO>();
        public List<CharacteristicDefinitionDTO> Characteristics { get; set; } = new List<CharacteristicDefinitionDTO>();
        public List<InventoryDefinitionDTO> Inventories { get; set; } = new List<InventoryDefinitionDTO>();
        public List<LifetimeDefinitionDTO> Lifetimes { get; set; } = new List<LifetimeDefinitionDTO>();
        public List<ProjectileDefinitionDTO> Projectiles { get; set; } = new List<ProjectileDefinitionDTO>();
        public List<TriggeredEffectDefinitionDTO> TriggeredEffects { get; set; } = new List<TriggeredEffectDefinitionDTO>();
        public List<EntityDefinitionDTO> Entities { get; set; } = new List<EntityDefinitionDTO>();

        public List<CombatRunDefinitionDTO> CombatRuns { get; set; } = new List<CombatRunDefinitionDTO>();
        public List<RoomDefinitionDTO> Rooms { get; set; } = new List<RoomDefinitionDTO>();
        public List<EntitySpawnRuleDTO> EntitySpawnRules { get; set; } = new List<EntitySpawnRuleDTO>();
        public List<CellDTO> Cells { get; set; } = new List<CellDTO>();

        public List<LocaleDTO> Locales { get; set; } = new List<LocaleDTO>();
    }
}