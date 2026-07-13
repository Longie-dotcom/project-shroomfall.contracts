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
        public string ID { get; set; } = string.Empty;
        public ItemType Type { get; set; }
        public ItemCategory Category { get; set; }
        public int? MaxStack { get; set; }
        public int? MaxDurability { get; set; }
        public EntityAction? TriggeredAction { get; set; }
        public ItemPresentationDefinitionDTO Presentation { get; set; } = new ItemPresentationDefinitionDTO();

        public ConsumableConfigDTO? ConsumableConfig { get; set; }
        public EquippableConfigDTO? EquippableConfig { get; set; }
        public PlaceableConfigDTO? PlaceableConfig { get; set; }
        public RangedConfigDTO? RangedConfig { get; set; }
        public MeleeConfigDTO? MeleeConfig { get; set; }

        public CostConfigDTO CostConfig { get; set; } = new CostConfigDTO();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/meta-domain")]
#endif
    public class ItemPresentationDefinitionDTO
    {
        public LocalizedTextDTO LocalizedText { get; set; } = new LocalizedTextDTO();
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