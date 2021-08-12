using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace smartSchool.WebApi.Helpers
{
    public static class Extensions
    {
        public static void AddPagination(this HttpResponse resp, int CurrentPage,
            int TotalPages, int PageSize, int TotalCount)
        {
            var paginationHeader = new PaginationHeader(CurrentPage,
            TotalPages, PageSize, TotalCount);

            var camelCaseFormatter = new JsonSerializerSettings();
            camelCaseFormatter.ContractResolver = new CamelCasePropertyNamesContractResolver();

            resp.Headers.Add("Pagination", JsonConvert.SerializeObject(
                paginationHeader, camelCaseFormatter));
            resp.Headers.Add("Access-Control-Expose-Header", "Pagination");

        }
    }
}