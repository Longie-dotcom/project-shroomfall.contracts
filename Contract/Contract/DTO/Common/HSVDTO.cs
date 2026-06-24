#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Common
{
#if NET9_0
    [ExportTsInterface(OutputDir = "common")]
#endif
    public class HSVDTO
    {
        public float H { get; set; }
        public float S { get; set; }
        public float V { get; set; }
    }
}