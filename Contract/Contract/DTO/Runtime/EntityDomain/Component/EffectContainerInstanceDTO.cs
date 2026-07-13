using Contract.DTO.Abstraction;
using Contract.DTO.Runtime.MetaDomain;
using System.Collections.Generic;

namespace Contract.DTO.Runtime.EntityDomain.Component
{
    public class EffectContainerInstanceDTO : ComponentInstanceDTO
    {
        public List<EffectInstanceDTO> ActiveEffects { get; set; } = new List<EffectInstanceDTO>();
    }
}