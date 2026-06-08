using Contract.DTO.Runtime;
using Contract.Enum.EntityDomain;

namespace Contract.DTO.Game
{
    public class EntityActedDTO
    {
        public string EntityInstanceID { get; set; } = string.Empty;
        public float X { get; set; }
        public float Y { get; set; }
        public EntityDirection Direction { get; set; }
        public EntityAction Action { get; set; }
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