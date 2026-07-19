using System.Collections.Generic;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Definition.LocalizationDomain
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/localization-domain")]
#endif
    public class LocaleDTO
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public bool IsDefault { get; set; }
        public bool IsEnabled { get; set; }

        public List<LocalizationEntryDTO> LocalizationEntries { get; set; } = new List<LocalizationEntryDTO>();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/localization-domain")]
#endif
    public class LocalizationEntryDTO
    {
        public string Key { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public string LocaleCode { get; set; } = string.Empty;
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/localization-domain")]
#endif
    public class LocalizedTextDTO
    {
        public string NameKey { get; set; } = string.Empty;
        public string DescriptionKey { get; set; } = string.Empty;
    }
}