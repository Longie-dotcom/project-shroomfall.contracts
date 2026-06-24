#if NET9_0 
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.Enum.WorldDomain
{
#if NET9_0
    [ExportTsEnum(OutputDir = "enums/world")]
#endif
    public enum RoomType
    {
        Village,
        Dungeon,

        PersonalSpace,
        Barn,
        Farm,
        House,
        Basement
    }
}
