using Contract.Enum.ItemDomain;
using System.Collections.Generic;

namespace Contract.DTO.Runtime
{
    public class InventoryRuntimeDTO
    {
        public string ID { get; set; } = string.Empty;
        public string DefinitionID { get; set; } = string.Empty;
        public List<ItemRuntimeDTO> Items { get; set; } = new List<ItemRuntimeDTO>();
    }

    public class ItemRuntimeDTO
    {
        public string ID { get; set; } = string.Empty;
        public string DefinitionID { get; set; } = string.Empty;
        public int Count { get; set; }
        public int? CurrentDurability { get; set; }
        public ItemQuality Quality { get; set; }
    }
}