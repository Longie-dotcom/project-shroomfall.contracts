using Contract.Enum.EntityDomain;

namespace Contract.DTO.Domain.Definition
{
    public class EntityDefinitionDTO
    {
        public string ID { get; set; } = string.Empty;
        public EntityType Type { get; set; }
        public EntityPresentationDefinitionDTO Presentation { get; set; } = new EntityPresentationDefinitionDTO();
    }

    public class EntityPresentationDefinitionDTO
    {
        public LocalizedTextDTO LocalizedText { get; set; } = new LocalizedTextDTO();
        public string? IconID { get; set; } = string.Empty;
    }
}