#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Common
{

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/common")] 
#endif
    public class ApiErrorDTO
    {
        public string Type { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string? Details { get; set; }
    }
}