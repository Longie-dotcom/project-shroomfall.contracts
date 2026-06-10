using Contract.DTO.Runtime;
using Contract.Enum.AttributeDomain;
using Contract.Enum.EntityDomain;
using System;

namespace Contract.DTO.Game
{
    public class EntityActedDTO
    {
        public string EntityInstanceID { get; set; } = string.Empty;
        public float X { get; set; }
        public float Y { get; set; }
        public EntityDirection Direction { get; set; }
        public EntityAction Action { get; set; }
        public string? UsedItemDefinitionDTO { get; set; } = string.Empty;
    }

    public class MessageChattedDTO
    {

    }

    public class EntityAppearanceChangedDTO
    {
        public string EntityInstanceID { get; set; } = string.Empty;
        public AppearanceRuntimeDTO Appearance { get; set; } = new AppearanceRuntimeDTO();
    }

    public class EntityVitalChangedDTO
    {
        public string EntityInstanceID { get; set; } = string.Empty;
        public AttributeType AttributeType { get; set; }
        public float NewValue { get; set; }
    }
}