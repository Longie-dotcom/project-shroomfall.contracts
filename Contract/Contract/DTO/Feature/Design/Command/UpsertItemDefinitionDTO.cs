using Contract.DTO.Definition.MetaDomain;
using Contract.Enum.EntityDomain;
using Contract.Enum.MetaDomain.Item;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Feature.Design.Command
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/design/command")]
#endif
    public class UpsertItemDefinitionDTO
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
}