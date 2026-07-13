using Contract.Enum.MetaDomain.Item;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Feature.Game.Command
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/game/command")]
#endif
    public class UseItemDTO
    {
        public string ItemInstanceID { get; set; } = string.Empty;
        public float TargetPositionX { get; set; }
        public float TargetPositionY { get; set; }
        public EquipmentSlot? UnequippedSlot { get; set; }
        public ItemUsageAction ItemUsageAction { get; set; }
    }
}