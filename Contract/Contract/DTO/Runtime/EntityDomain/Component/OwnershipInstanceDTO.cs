using Contract.DTO.Abstraction;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Runtime.EntityDomain.Component
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/entity-domain/component")]
#endif
    public class OwnershipInstanceDTO : ComponentInstanceDTO
    {
        public string UserID { get; set; } = string.Empty;
        public string PersonalRoomID { get; set; } = string.Empty;
    }
}