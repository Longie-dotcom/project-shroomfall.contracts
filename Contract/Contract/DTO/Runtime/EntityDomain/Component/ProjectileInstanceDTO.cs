using Contract.DTO.Abstraction;
using System.Numerics;

namespace Contract.DTO.Runtime.EntityDomain.Component
{
    public class ProjectileInstanceDTO : ComponentInstanceDTO
    {
        public float Velocity { get; set; }
        public Vector2 Direction { get; set; }
    }
}