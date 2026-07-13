using Contract.DTO.Definition.LocalizationDomain;
using Contract.Enum.EntityDomain;
using Contract.Enum.MetaDomain.Item;
using System.Collections.Generic;

#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Definition.MetaDomain
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/meta-domain")]
#endif
    public class ItemDefinitionDTO
    {
        public string Id { get; set; } = string.Empty;
        public ItemType Type { get; set; }
        public ItemCategory Category { get; set; }
#if NET9_0
        [TsOptional]
#endif
        public int? MaxStack { get; set; }
#if NET9_0
        [TsOptional]
#endif
        public int? MaxDurability { get; set; }
#if NET9_0
        [TsOptional]
#endif
        public EntityAction? TriggeredAction { get; set; }
#if NET9_0
        [TsOptional]
#endif
        public ItemPresentationDefinitionDTO Presentation { get; set; } = new ItemPresentationDefinitionDTO();

#if NET9_0
        [TsOptional]
#endif
        public ConsumableConfigDTO? ConsumableConfig { get; set; }
#if NET9_0
        [TsOptional]
#endif
        public EquippableConfigDTO? EquippableConfig { get; set; }
#if NET9_0
        [TsOptional]
#endif
        public PlaceableConfigDTO? PlaceableConfig { get; set; }
#if NET9_0
        [TsOptional]
#endif
        public RangedConfigDTO? RangedConfig { get; set; }
#if NET9_0
        [TsOptional]
#endif
        public MeleeConfigDTO? MeleeConfig { get; set; }

        public CostConfigDTO CostConfig { get; set; } = new CostConfigDTO();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/meta-domain")]
#endif
    public class ItemPresentationDefinitionDTO
    {
        public LocalizedTextDTO LocalizedText { get; set; } = new LocalizedTextDTO();
#if NET9_0
        [TsOptional]
#endif
        public string? IconID { get; set; } = string.Empty;
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/meta-domain")]
#endif
    public class ConsumableConfigDTO
    {
        public List<string> EffectDefinitionIDs { get; set; } = new List<string>();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/meta-domain")]
#endif
    public class EquippableConfigDTO
    {
        public EquipmentSlot Slot { get; set; }
        public List<string> EffectDefinitionIDs { get; set; } = new List<string>();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/meta-domain")]
#endif
    public class PlaceableConfigDTO
    {
        public string EntityDefinitionID { get; set; } = string.Empty;
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/meta-domain")]
#endif
    public class RangedConfigDTO
    {
        public string EntityDefinitionID { get; set; } = string.Empty;
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/meta-domain")]
#endif
    public class MeleeConfigDTO
    {
        public string EntityDefinitionID { get; set; } = string.Empty;
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/meta-domain")]
#endif
    public class CostConfigDTO
    {
        public ItemConsumptionMethod Method { get; set; }
    }
}