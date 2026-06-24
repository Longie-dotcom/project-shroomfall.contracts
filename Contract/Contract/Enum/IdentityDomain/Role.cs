#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.Enum.IdentityDomain
{
#if NET9_0
    [ExportTsEnum(OutputDir = "enums/identity")]
#endif
    public enum Role
    {
        Designer, Admin, Player
    }
}