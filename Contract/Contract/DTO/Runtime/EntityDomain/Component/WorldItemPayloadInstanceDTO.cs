using Contract.DTO.Abstraction;
using Contract.DTO.Runtime.MetaDomain;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Runtime.EntityDomain.Component
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/entity-domain/component")]
#endif
    public class WorldItemPayloadInstanceDTO : ComponentInstanceDTO
    {
        public ItemInstanceDTO Payload { get; set; } = new ItemInstanceDTO();
    }
}