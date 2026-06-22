namespace Contract.DTO.Design
{
    public class UpdateDefinitionDTO
    {
        public string? Key { get; set; }
        public string? Description { get; set; }
    }

    public class UpdateDefinitionNotificationDTO
    {
        public string Key { get; set; } = string.Empty;
        public long Version { get; set; }
    }

    public class UserRefreshDTO
    {
        public string DefinitionVersion { get; set; } = string.Empty;
    }
}