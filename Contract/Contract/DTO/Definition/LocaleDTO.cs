using System.Collections.Generic;

namespace Contract.DTO.Definition
{
    public class LocaleDTO
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public bool IsDefault { get; set; }
        public bool IsEnabled { get; set; }

        public List<LocalizationEntryDTO> LocalizationEntries { get; set; } = new List<LocalizationEntryDTO>();
    }

    public class LocalizedTextDTO
    {
        public string NameKey { get; set; } = string.Empty;
        public string DescriptionKey { get; set; } = string.Empty;
    }

    public class LocalizationEntryDTO
    {
        public string ID { get; set; } = string.Empty;
        public string Key { get; set; } = string.Empty;
        public string LocaleCode { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }
}