#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Common
{
#if NET9_0
    [ExportTsInterface(OutputDir = "common")]
#endif
    public class Vector2DTO
    {
        public float X { get; set; }
        public float Y { get; set; }
    }
}