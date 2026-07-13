using Contract.Enum.MetaDomain.Item;

namespace Contract.DTO.Runtime.MetaDomain
{
    public class ItemInstanceDTO
    {
        public string ID { get; set; } = string.Empty;
        public string DefinitionID { get; set; } = string.Empty;
        public int Amount { get; set; }
        public ItemQuality Quality { get; set; }
        public int? Durability { get; set; }
    }
}