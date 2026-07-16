#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

using Contract.DTO.Runtime.MetaDomain;
using Contract.Enum.MetaDomain.Item;

namespace Contract.DTO.Feature.Game.Response
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/game/response")]
#endif
    public class InventoryItemChangedDTO
    {
        public ItemInstanceDTO Item { get; set; } = new ItemInstanceDTO();
        public ItemInventorySyncEvent EventType { get; set; }
    }
}