using Contract.DTO.Domain.Definition;
using Contract.Enum.EntityDomain;
using System.Collections.Generic;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Design
{
#if NET9_0
    [ExportTsInterface(OutputDir = "design/command")]
#endif
    public class UpdateDefinitionDTO
    {
        public string? Key { get; set; }
        public string? Description { get; set; }
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "design/command")]
#endif
    public class UserRefreshDTO
    {
        public string DefinitionVersion { get; set; } = string.Empty;
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "design/command")]
#endif
    public class UpsertEntityDefinitionDTO
    {
        public string ID { get; set; } = string.Empty;
        public EntityType Type { get; set; }
        public List<ComponentDefinitionDTO> Components { get; set; } = new List<ComponentDefinitionDTO>();
    }
}