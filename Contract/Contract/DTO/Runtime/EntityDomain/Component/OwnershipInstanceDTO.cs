using Contract.DTO.Abstraction;
using Contract.Enum.EntityDomain;
using System;
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
        public string Name { get; set; } = string.Empty;
#if NET9_0
        [TsOptional]
#endif
        public DateTime? BirthDate { get; set; }
        public Gender Gender { get; set; }
    }
}