using Contract.DTO.Abstraction;
using Contract.DTO.Common;

namespace Contract.DTO.Runtime.EntityDomain.Component
{
    public class AppearanceInstanceDTO : ComponentInstanceDTO
    {
        public string SkinID { get; set; } = string.Empty;
        public HSVDTO SkinColor { get; set; } = new HSVDTO();
    }
}