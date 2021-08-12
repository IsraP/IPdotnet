using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace smartSchool.WebApi.Helpers
{
    public class PageList<T> : List<T>
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }

        public PageList(List<T> items, int count, int pageNum, int pageSize)
        {
            TotalCount = count;
            PageSize = pageSize;
            CurrentPage = pageNum;
            TotalPages = (int)Math.Ceiling(count / (double)PageSize);

            this.AddRange(items);
        }

        public static async Task<PageList<T>> CreateAsync(IQueryable<T> src, int pageNumber, int pageSize)
        {
            var count = await src.CountAsync();
            var items = await src.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
            return new PageList<T>(items, count, pageNumber, pageSize);
        }
    }
}