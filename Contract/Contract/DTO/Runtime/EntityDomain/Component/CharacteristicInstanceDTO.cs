using Contract.DTO.Abstraction;
using Contract.Enum.MetaDomain.Effect;
using System.Collections.Generic;

namespace Contract.DTO.Runtime.EntityDomain.Component
{
    public class CharacteristicInstanceDTO : ComponentInstanceDTO
    {
        public List<AttributeValueInstanceDTO> Cores { get; set; } = new List<AttributeValueInstanceDTO>();
        public List<AttributeValueInstanceDTO> Vitals { get; set; } = new List<AttributeValueInstanceDTO>();
        public int CurrentLevel { get; set; }
    }

    public class AttributeValueInstanceDTO
    {
        public AttributeType AttributeType { get; set; }
        public float Value { get; set; }
    }
}