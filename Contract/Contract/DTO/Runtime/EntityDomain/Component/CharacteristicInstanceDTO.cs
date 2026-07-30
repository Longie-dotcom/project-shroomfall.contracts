using Contract.DTO.Abstraction;
using Contract.Enum.MetaDomain.Effect;
using System.Collections.Generic;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Runtime.EntityDomain.Component
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/entity-domain/component")]
#endif
    public class CharacteristicInstanceDTO : ComponentInstanceDTO
    {
        public List<AttributeValueInstanceDTO> Cores { get; set; } = new List<AttributeValueInstanceDTO>();
        public List<AttributeValueInstanceDTO> Vitals { get; set; } = new List<AttributeValueInstanceDTO>();
        public int CurrentLevel { get; set; }
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/entity-domain/component")]
#endif
    public class AttributeValueInstanceDTO
    {
        public AttributeType AttributeType { get; set; }
        public float Value { get; set; }
    }
}