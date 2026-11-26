#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.Enum.EntityDomain
{
#if NET9_0
    [ExportTsEnum(OutputDir = "enum/entity-domain")]
#endif
    public enum Gender
    {
        Unspecified = 0,
        Male = 1,
        Female = 2,
        Other = 3,
    }
}
