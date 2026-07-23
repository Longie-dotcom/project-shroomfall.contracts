using Contract.Attributes;
using Contract.DTO.Abstraction;
using Contract.Enum.EntityDomain;
using Contract.Enum.MetaDomain.Effect;
using System;
using System.Collections.Generic;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Definition.EntityDomain.Component
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/entity-domain/component")]
#endif
    [EntityComponent(EntityType.Creature, EntityType.Player, Required = true)]
    public class CharacteristicDefinitionDTO : ComponentDefinitionDTO
    {
        public CharacteristicDefinitionDTO() { ComponentType = nameof(CharacteristicDefinitionDTO); }

        public List<AttributeValueDTO> AttributeValues { get; set; } = new List<AttributeValueDTO>();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/entity-domain/component")]
#endif
    public class AttributeValueDTO
    {
#if NET9_0
        [TsOptional]
#endif
        public Guid? ID { get; set; }
        public AttributeType Type { get; set; }
        public float BaseValue { get; set; }
        public float Min { get; set; }
        public float Max { get; set; }
        public List<AttributeGrowthValueDTO> AttributeGrowthValues { get; set; } = new List<AttributeGrowthValueDTO>();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/entity-domain/component")]
#endif
    public class AttributeGrowthValueDTO
    {
#if NET9_0
        [TsOptional]
#endif
        public Guid? ID { get; set; }
        public int Level { get; set; }
        public float GrowthValue { get; set; }
    }
}