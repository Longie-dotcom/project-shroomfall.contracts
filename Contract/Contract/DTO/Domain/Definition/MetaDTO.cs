using Contract.Enum.EntityDomain;
using Contract.Enum.MetaDomain.Effect;
using Contract.Enum.MetaDomain.Item;
using System.Collections.Generic;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Domain.Definition
{
    #region Effect
#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/meta")]
#endif
    public class EffectDefinitionDTO
    {
        public string ID { get; set; } = string.Empty;
        public EffectType Type { get; set; }
        public AttributeType AttributeType { get; set; }
        public AttributeType? SourceType { get; set; }
        public float Value { get; set; }
        public float? Duration { get; set; }
        public float? Interval { get; set; }
        public EffectPresentationDefinitionDTO Presentation { get; set; } = new EffectPresentationDefinitionDTO();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/meta")]
#endif
    public class EffectPresentationDefinitionDTO
    {
        public LocalizedTextDTO LocalizedText { get; set; } = new LocalizedTextDTO();
        public string? IconID { get; set; } = string.Empty;
    }
    #endregion

    #region Item
#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/meta")]
#endif
    public class ItemDefinitionDTO
    {
        public string ID { get; set; } = string.Empty;
        public ItemType Type { get; set; }
        public ItemCategory Category { get; set; }
        public int? MaxStack { get; set; }
        public int? MaxDurability { get; set; }
        public EntityAction? TriggeredAction { get; set; }
        public ItemPresentationDefinitionDTO Presentation { get; set; } = new ItemPresentationDefinitionDTO();

        // Configuration per type
        public SpawnEntityConfigDTO? SpawnEntityConfig { get; set; }
        public ApplyEffectConfigDTO? ApplyEffectConfig { get; set; }
        public EquipConfigDTO? EquipConfig { get; set; }

        public CostConfigDTO CostConfig { get; set; } = new CostConfigDTO();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/meta")]
#endif
    public class ItemPresentationDefinitionDTO
    {
        public LocalizedTextDTO LocalizedText { get; set; } = new LocalizedTextDTO();
        public string? IconID { get; set; } = string.Empty;
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/meta")]
#endif
    public class SpawnEntityConfigDTO
    {
        public string EntityDefinitionID { get; set; } = string.Empty;
        public SpawnTargetType TargetType { get; set; } = SpawnTargetType.WorldPosition;
        public float MaxRange { get; set; }
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/meta")]
#endif
    public class ApplyEffectConfigDTO
    {
        public List<string> EffectDefinitionIDs { get; set; } = new List<string>();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/meta")]
#endif
    public class EquipConfigDTO
    {
        public EquipmentSlot Slot { get; set; }
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/meta")]
#endif
    public class CostConfigDTO
    {
        public ItemConsumptionMethod Method { get; set; }
        public int Value { get; set; } = 1;
    }
    #endregion
}