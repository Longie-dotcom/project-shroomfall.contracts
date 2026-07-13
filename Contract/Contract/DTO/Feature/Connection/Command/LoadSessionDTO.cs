#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Feature.Connection.Command
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/connection/command")]
#endif
    public class LoadSessionDTO
    {
        public string PlayerInstanceID { get; set; } = string.Empty;
    }
}