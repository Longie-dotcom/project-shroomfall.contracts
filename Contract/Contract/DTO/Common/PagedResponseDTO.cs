using System;
using System.Collections.Generic;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Common
{
#if NET9_0
    [ExportTsInterface(OutputDir = "common")]
#endif
    public class PagedResponseDTO<T>
    {
        public List<T> Items { get; set; } = new List<T>();
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }

#if NET9_0
        [TsIgnore]
#endif
        public int TotalPages => (int)Math.Ceiling((double)TotalCount / PageSize);

        public PagedResponseDTO() { }

        public PagedResponseDTO(
            List<T> items,
            int totalCount,
            int pageNumber,
            int pageSize)
        {
            Items = items;
            TotalCount = totalCount;
            PageNumber = pageNumber < 1 ? 1 : pageNumber;
            PageSize = pageSize < 1 ? 10 : pageSize;
        }
    }
}