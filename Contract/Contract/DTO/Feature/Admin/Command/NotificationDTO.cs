using System;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Feature.Admin.Command
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/admin/command")]
#endif
    public class NotificationDTO
    {
        public string Id { get; set; } = string.Empty;
        public string Objective { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
