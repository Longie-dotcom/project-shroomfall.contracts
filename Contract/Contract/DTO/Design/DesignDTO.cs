using Contract.DTO.Definition;
using System;
using System.Collections.Generic;

namespace Contract.DTO.Design
{
    public class DefinitionVersionLogDTO
    {
        public string ID { get; set; } = string.Empty;
        public string Key { get; set; } = string.Empty;
        public long Version { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class DefinitionSnapshotDTO
    {
        public long Version { get; set; }

        public List<AttributeDefinitionDTO> AttributeDefinitions { get; set; } = new List<AttributeDefinitionDTO>();
        public List<AttributeValueDefinitionDTO> AttributeValues { get; set; } = new List<AttributeValueDefinitionDTO>();
        public List<CharacteristicDefinitionDTO> Characteristics { get; set; } = new List<CharacteristicDefinitionDTO>();
        public List<EffectDefinitionDTO> Effects { get; set; } = new List<EffectDefinitionDTO>();


        public List<InventoryDefinitionDTO> Inventories { get; set; } = new List<InventoryDefinitionDTO>();
        public List<InventoryItemDefinitionDTO> InventoryItems { get; set; } = new List<InventoryItemDefinitionDTO>();
        public List<ItemDefinitionDTO> Items { get; set; } = new List<ItemDefinitionDTO>();
        public List<ItemConfigurationDefinitionDTO> ItemConfigurations { get; set; } = new List<ItemConfigurationDefinitionDTO>();
        public List<ItemEffectDefinitionDTO> ItemEffects { get; set; } = new List<ItemEffectDefinitionDTO>();

        public List<EntityDefinitionDTO> Entities { get; set; } = new List<EntityDefinitionDTO>();

        public List<CellDefinitionDTO> Cells { get; set; } = new List<CellDefinitionDTO>();
        public List<EntitySpawnRuleDefinitionDTO> EntitySpawnRules { get; set; } = new List<EntitySpawnRuleDefinitionDTO>();
        public List<RoomDefinitionDTO> Rooms { get; set; } = new List<RoomDefinitionDTO>();
        public List<RoomConnectionDefinitionDTO> RoomConnections { get; set; } = new List<RoomConnectionDefinitionDTO>();
        public List<SpawnAreaDefinitionDTO> SpawnAreas { get; set; } = new List<SpawnAreaDefinitionDTO>();

        public List<LocaleDTO> Locales { get; set; } = new List<LocaleDTO>();
    }
}