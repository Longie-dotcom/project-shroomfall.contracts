#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Feature.Design.Response
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/design/response")]
#endif
    public class UpdateDefinitionNotificationDTO
    {
        public string Key { get; set; } = string.Empty;
        public long Version { get; set; }
    }
}