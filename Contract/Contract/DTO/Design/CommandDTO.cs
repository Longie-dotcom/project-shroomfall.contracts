using Contract.DTO.Domain.Definition;
using Contract.Enum.EntityDomain;
using Contract.Enum.MetaDomain.Effect;
using Contract.Enum.MetaDomain.Item;
using System.Collections.Generic;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Design
{
#if NET9_0
    [ExportTsInterface(OutputDir = "design/commands")]
#endif
    public class EntityDefinitionQueryDTO
    {
        public string? SearchTerm { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "design/commands")]
#endif
    public class ItemDefinitionQueryDTO
    {
        public string? SearchTerm { get; set; }
        public ItemType? Type { get; set; }
        public ItemCategory? Category { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "design/commands")]
#endif
    public class EffectDefinitionQueryDTO
    {
        public string? SearchTerm { get; set; }
        public EffectType? Type { get; set; }
        public AttributeType? AttributeType { get; set; }
        public AttributeType? SourceType { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "design/commands")]
#endif
    public class UpdateDefinitionDTO
    {
        public string? Key { get; set; }
        public string? Description { get; set; }
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "design/commands")]
#endif
    public class UserRefreshDTO
    {
        public string DefinitionVersion { get; set; } = string.Empty;
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "design/commands")]
#endif
    public class UpsertItemDefinitionDTO
    {
        public string ID { get; set; } = string.Empty;
        public ItemType Type { get; set; }
        public ItemCategory Category { get; set; }
        public int? MaxStack { get; set; }
        public int? MaxDurability { get; set; }
        public EntityAction? TriggeredAction { get; set; }
        public string? IconID { get; set; } = string.Empty;
        public SpawnEntityConfigDTO? SpawnEntityConfig { get; set; }
        public ApplyEffectConfigDTO? ApplyEffectConfig { get; set; }
        public EquipConfigDTO? EquipConfig { get; set; }
        public CostConfigDTO CostConfig { get; set; } = new CostConfigDTO();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "design/commands")]
#endif
    public class UpsertEffectDefinitionDTO
    {
        public string ID { get; set; } = string.Empty;
        public EffectType Type { get; set; }
        public AttributeType AttributeType { get; set; }
        public AttributeType? SourceType { get; set; }
        public float Value { get; set; }
        public float? Duration { get; set; }
        public float? Interval { get; set; }
        public string? IconID { get; set; } = string.Empty;
    }

#if NET9_0
[ExportTsInterface(OutputDir = "design/commands")]
#endif
    public class UpsertEntityDefinitionDTO
    {
        public string ID { get; set; } = string.Empty;
        public EntityType Type { get; set; }
        public List<ComponentDefinitionDTO> Components { get; set; } = new List<ComponentDefinitionDTO>();
    }
}