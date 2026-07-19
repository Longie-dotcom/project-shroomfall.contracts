#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

using System;

namespace Contract.DTO.Feature.Admin.Response
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/admin/response")]
#endif
    public class TelemetryEventDTO
    {
        public string Code { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; }
        public string Severity { get; set; } = string.Empty;
    }
}
