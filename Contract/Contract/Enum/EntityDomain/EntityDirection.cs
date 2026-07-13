#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.Enum.EntityDomain
{
#if NET9_0
    [ExportTsEnum(OutputDir = "enum/entity-domain")]
#endif
    public enum EntityDirection : byte
    {
        DOWN = 0,
        RIGHT = 1,
        UP = 2,
        LEFT = 3,
    }
}