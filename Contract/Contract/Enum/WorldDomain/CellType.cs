#if NET9_0 
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.Enum.WorldDomain
{
#if NET9_0
    [ExportTsEnum(OutputDir = "enum/world-domain")]
#endif
    public enum CellType
    {
        Walkable,
        NonWalkable
    }
}
