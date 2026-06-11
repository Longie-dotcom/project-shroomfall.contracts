using Contract.DTO.Common;
using Contract.Enum.EntityDomain;

namespace Contract.DTO.Definition
{
    public class EntityDefinitionDTO
    {
        public string ID { get; set; } = string.Empty;
        public EntityType Type { get; set; }
        public LocalizedTextDTO LocalizedText { get; set; } = new LocalizedTextDTO();
        public AppearanceDefinitionDTO Appearance { get; set; } = new AppearanceDefinitionDTO();
        public CollisionDefinitionDTO Collision { get; set; } = new CollisionDefinitionDTO();
    }

    public class AreaEffectDefinitionDTO : EntityDefinitionDTO
    {
        public float Duration { get; set; }
    }

    public class ProjectileDefinitionDTO : EntityDefinitionDTO
    {
        public float Velocity { get; set; }
        public float Duration { get; set; }
    }

    public class PortalDefinitionDTO : EntityDefinitionDTO
    {
        public CollisionDefinitionDTO Entrance { get; set; } = new CollisionDefinitionDTO();
        public Vector2DTO EntrancePosition { get; set; } = new Vector2DTO();
    }

    public class WorldObjectDefinitionDTO : EntityDefinitionDTO
    {
        public WorldObjectInteractionType InteractionType { get; set; }
        public bool IsInteractable { get; set; }
        public bool IsPickupable { get; set; }
        public string? InventoryID { get; set; }
    }

    public class CreatureDefinitionDTO : EntityDefinitionDTO
    {
        public string CharacteristicID { get; set; } = string.Empty;
        public string InventoryID { get; set; } = string.Empty;
        public int Level { get; set; }
    }

    public class PlayerDefinitionDTO : CreatureDefinitionDTO
    {

    }

    public class AppearanceDefinitionDTO
    {
        public string SkinID { get; set; } = string.Empty;
        public HSVDTO SkinColor { get; set; } = new HSVDTO();
        public string HairID { get; set; } = string.Empty;
        public string EyesID { get; set; } = string.Empty;
        public string ShirtID { get; set; } = string.Empty;
        public string PantID { get; set; } = string.Empty;
        public HSVDTO HairColor { get; set; } = new HSVDTO();
        public HSVDTO PantColor { get; set; } = new HSVDTO();
    }

    public class CollisionDefinitionDTO
    {
        public CollisionShapeType ShapeType { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float Radius { get; set; }
        public bool IsBlocking { get; set; }
        public bool IsTrigger { get; set; }
        public float OffsetX { get; set; }
        public float OffsetY { get; set; }
    }
}