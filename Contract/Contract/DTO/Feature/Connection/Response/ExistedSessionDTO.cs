using Contract.DTO.Runtime.EntityDomain.Component;
using System.Collections.Generic;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Feature.Connection.Response
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/connection/response")]
#endif
    public class ExistedSessionDTO
    {
        public List<ExistedSessionEntryDTO> Sessions { get; set; } = new List<ExistedSessionEntryDTO>();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/connection/response")]
#endif
    public class ExistedSessionEntryDTO
    {
        public string PlayerInstanceID { get; set; } = string.Empty;
        public AppearanceInstanceDTO PlayerAppearance { get; set; } = new AppearanceInstanceDTO();
    }
}