using Contract.DTO.Domain.Definition;
using Contract.Enum.EntityDomain;
using System.Collections.Generic;

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

    public class UpsertEntityDefinitionDTO
    {
        public string ID { get; set; } = string.Empty;
        public EntityType Type { get; set; }
        public List<ComponentDefinitionDTO> Components { get; set; } = new List<ComponentDefinitionDTO>();
    }
}