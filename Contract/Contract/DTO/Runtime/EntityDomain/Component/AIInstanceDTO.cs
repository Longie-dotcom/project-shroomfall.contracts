using Contract.DTO.Abstraction;
using Contract.Enum.EntityDomain;

namespace Contract.DTO.Runtime.EntityDomain.Component
{
    public class AIInstanceDTO : ComponentInstanceDTO
    {
        public AIState AIState { get; set; } = AIState.Idle;
        public string? TargetEntityId { get; set; }
        public bool IsAIControlled { get; set; } = true;
        public float ThinkCooldownRemaining { get; set; }
        public float AttackTimer { get; set; }
        public float LeashDistance { get; set; } = 10.0f;
        public float AggroRadius { get; set; } = 5.0f;
    }
}