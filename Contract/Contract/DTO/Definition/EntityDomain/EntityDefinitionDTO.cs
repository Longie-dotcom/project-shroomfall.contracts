using Contract.DTO.Abstraction;
using Contract.DTO.Definition.LocalizationDomain;
using Contract.Enum.EntityDomain;
using System.Collections.Generic;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Definition.EntityDomain.Component
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/entity-domain")]
#endif
    public class EntityDefinitionDTO
    {
        public string Id { get; set; } = string.Empty;
        public EntityType Type { get; set; }
        public List<ComponentDefinitionDTO> Components { get; set; } = new List<ComponentDefinitionDTO>();
#if NET9_0
        [TsOptional]
#endif
        public EntityPresentationDefinitionDTO Presentation { get; set; } = new EntityPresentationDefinitionDTO();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/entity-domain")]
#endif
    public class EntityPresentationDefinitionDTO
    {
        public LocalizedTextDTO LocalizedText { get; set; } = new LocalizedTextDTO();
#if NET9_0
        [TsOptional]
#endif
        public string? IconID { get; set; } = string.Empty;
    }
}