using Contract.Enum.AttributeDomain;
using System.Collections.Generic;

namespace Contract.DTO.Runtime
{
    public class AttributeValueRuntimeDTO
    {
        public AttributeType AttributeType { get; set; }
        public float Value { get; set; }
    }

    public class CharacteristicRuntimeDTO
    {
        public string ID { get; set; } = string.Empty;
        public string DefinitionID { get; set; } = string.Empty;
        public List<AttributeValueRuntimeDTO> Cores { get; set; } = new List<AttributeValueRuntimeDTO>();
        public List<AttributeValueRuntimeDTO> Vitals { get; set; } = new List<AttributeValueRuntimeDTO>();
    }

    public class EffectRuntimeDTO
    {
        public string ID { get; set; } = string.Empty;
        public string DefinitionID { get; set; } = string.Empty;
        public float? RemainingTime { get; set; }
        public string? SourceItemInstanceID { get; set; }
    }
}