using Contract.DTO.Domain.Definition;
using System;
using System.Collections.Generic;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Design
{
#if NET9_0
    [ExportTsInterface(OutputDir = "design/responses")]
#endif
    public class DefinitionVersionLogDTO
    {
        public string ID { get; set; } = string.Empty;
        public string Key { get; set; } = string.Empty;
        public long Version { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "design/responses")]
#endif
    public class UpdateDefinitionNotificationDTO
    {
        public string Key { get; set; } = string.Empty;
        public long Version { get; set; }
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "design/responses")]
#endif
    public class DefinitionSnapshotDTO
    {
        public long Version { get; set; }

        public List<AttributeDefinitionDTO> Attributes { get; set; } = new List<AttributeDefinitionDTO>();
        public List<EffectDefinitionDTO> Effects { get; set; } = new List<EffectDefinitionDTO>();
        public List<ItemDefinitionDTO> Items { get; set; } = new List<ItemDefinitionDTO>();

        public List<EntityDefinitionDTO> Entities { get; set; } = new List<EntityDefinitionDTO>();
        public List<InteractableDefinitionDTO> Interactables { get; set; } = new List<InteractableDefinitionDTO>();
        public List<PortalDefinitionDTO> Portals { get; set; } = new List<PortalDefinitionDTO>();

        public List<CellDefinitionDTO> Cells { get; set; } = new List<CellDefinitionDTO>();
        public List<EntitySpawnRuleDefinitionDTO> EntitySpawnRules { get; set; } = new List<EntitySpawnRuleDefinitionDTO>();
        public List<RoomDefinitionDTO> Rooms { get; set; } = new List<RoomDefinitionDTO>();
        public List<RoomConnectionDefinitionDTO> RoomConnections { get; set; } = new List<RoomConnectionDefinitionDTO>();

        public List<LocaleDTO> Locales { get; set; } = new List<LocaleDTO>();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "design/responses")]
#endif
    public class ExistLocalesDTO
    {
        public List<LocaleDTO> Locales { get; set; } = new List<LocaleDTO>();
    }
}