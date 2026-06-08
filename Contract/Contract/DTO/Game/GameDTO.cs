using Contract.DTO.Runtime;

namespace Contract.DTO.Game
{
    public class EntityMovedDTO
    {
        public string EntityInstanceID { get; set; } = string.Empty;
        public float X { get; set; }
        public float Y { get; set; }
    }

    public class MessageChattedDTO
    {

    }

    public class PlayerAppearanceChangedDTO
    {
        public string EntityInstanceID { get; set; } = string.Empty;
        public PlayerAppearanceRuntimeDTO Appearance { get; set; } = new PlayerAppearanceRuntimeDTO();
    }
}