using Contract.DTO.Abstraction;
using Contract.DTO.Runtime.MetaDomain;

namespace Contract.DTO.Runtime.EntityDomain.Component
{
    public class WorldItemPayloadInstanceDTO : ComponentInstanceDTO
    {
        public ItemInstanceDTO Payload { get; set; } = new ItemInstanceDTO();
    }
}