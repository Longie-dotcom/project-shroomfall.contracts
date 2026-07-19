using Contract.Enum.MetaDomain.Item;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Runtime.MetaDomain
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/meta-domain")]
#endif
    public class ItemInstanceDTO
    {
        public string ID { get; set; } = string.Empty;
        public string DefinitionID { get; set; } = string.Empty;
        public int Amount { get; set; }
        public ItemQuality Quality { get; set; }
        public int? Durability { get; set; }
    }
}