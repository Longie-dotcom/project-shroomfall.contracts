using Contract.DTO.Abstraction;
using Contract.DTO.Common;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Definition.EntityDomain.Component
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/entity-domain/component")]
#endif
    public class AppearanceDefinitionDTO : ComponentDefinitionDTO
    {
        public AppearanceDefinitionDTO() { ComponentType = nameof(AppearanceDefinitionDTO); }

#if NET9_0
        [TsIgnore]
#endif
        public string? SkinID { get; set; } = string.Empty;
        public HSVDTO SkinColor { get; set; } = new HSVDTO();
    }
}