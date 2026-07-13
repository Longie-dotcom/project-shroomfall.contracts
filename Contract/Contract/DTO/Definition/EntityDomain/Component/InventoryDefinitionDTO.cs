using Contract.DTO.Abstraction;
using Contract.Enum.MetaDomain.Item;
using System;
using System.Collections.Generic;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Definition.EntityDomain.Component
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/entity-domain/component")]
#endif
    public class InventoryDefinitionDTO : ComponentDefinitionDTO
    {
        public InventoryDefinitionDTO() { ComponentType = nameof(InventoryDefinitionDTO); }

        public int SlotCount { get; set; }
        public List<InventoryEntryDTO> DefaultItems { get; set; } = new List<InventoryEntryDTO>();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/entity-domain/component")]
#endif
    public class InventoryEntryDTO
    {
#if NET9_0
        [TsOptional]
#endif
        public Guid? ID { get; set; }
        public string DefinitionID { get; set; } = string.Empty;
        public int Amount { get; set; }
        public ItemQuality Quality { get; set; }
    }
}