using Contract.Enum.NotificationDomain;
using System;
using System.Collections.Generic;
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
        public NotificationType Type { get; set; } = NotificationType.Announcement;
        public LocaleNotificationDTO Objective { get; set; } = new LocaleNotificationDTO();
        public LocaleNotificationDTO Message { get; set; } = new LocaleNotificationDTO();
        public DateTime CreatedAt { get; set; }
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/admin/command")]
#endif
    public class LocaleNotificationDTO
    {
        public List<LocaleNotificationEntryDTO> Entries { get; set; } = new List<LocaleNotificationEntryDTO>();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/admin/command")]
#endif
    public class LocaleNotificationEntryDTO
    {
        public string Key { get; set; } = string.Empty;

        public string Value { get; set; } = string.Empty;
    }
}
