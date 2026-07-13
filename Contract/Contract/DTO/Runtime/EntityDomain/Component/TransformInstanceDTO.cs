using Contract.DTO.Abstraction;
using Contract.DTO.Common;
using Contract.Enum.EntityDomain;

namespace Contract.DTO.Runtime.EntityDomain.Component
{
    public class TransformInstanceDTO : ComponentInstanceDTO
    {
        public int LayerZ { get; set; }
        public Vector2DTO Position { get; set; } = new Vector2DTO();
        public EntityDirection FacingDirection { get; set; }
        public EntityAction CurrentAction { get; set; }
    }
}