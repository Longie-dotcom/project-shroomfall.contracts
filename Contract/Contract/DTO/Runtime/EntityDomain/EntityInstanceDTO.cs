using Contract.DTO.Abstraction;
using System.Collections.Generic;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Runtime.EntityDomain
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/entity-domain")]
#endif
    public class EntityInstanceDTO
    {
        public string Id { get; set; } = string.Empty;
        public string DefinitionID { get; set; } = string.Empty;
        public List<ComponentInstanceDTO> Components { get; set; } = new List<ComponentInstanceDTO>();
    }
}