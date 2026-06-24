#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.Enum.EntityDomain
{
#if NET9_0
    [ExportTsEnum(OutputDir = "enums/entity")]
#endif
    public enum WorldObjectInteractionType
    {
        None,
        Crafting,
        Fusion,
        Container,
        Shop,
        Decoration,
        Farm
    }
}