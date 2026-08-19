using Contract.Common;
using Contract.DTO.Abstraction;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Runtime.EntityDomain.Component
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/entity-domain/component")]
#endif
    public class AppearanceInstanceDTO : ComponentInstanceDTO
    {
        public string SkinID { get; set; } = string.Empty;
        public HSV SkinColor { get; set; } = new HSV();
    }
}