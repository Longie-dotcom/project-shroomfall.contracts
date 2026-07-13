using Contract.DTO.Abstraction;

namespace Contract.DTO.Runtime.EntityDomain.Component
{
    public class OwnershipInstanceDTO : ComponentInstanceDTO
    {
        public string UserID { get; set; } = string.Empty;
        public string PersonalRoomID { get; set; } = string.Empty;
    }
}