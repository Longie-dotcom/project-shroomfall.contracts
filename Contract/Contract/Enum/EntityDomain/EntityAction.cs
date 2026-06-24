#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.Enum.EntityDomain
{
#if NET9_0
    [ExportTsEnum(OutputDir = "enums/entity")]
#endif
    public enum EntityAction : byte
    {
        // --- Movement ---
        IDLE = 0,
        RUN = 1,
        SWING = 2,
        DAMAGED = 3,
        SHOOT = 4,
        NONE = 5,
    }
}