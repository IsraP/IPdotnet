namespace smartSchool.WebApi.Helpers
{
    public class PageParams
    {
        public static int maxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int pageSize = 10;
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > maxPageSize)? maxPageSize : value;}
        }

        public string Name { get; set; } = string.Empty;
        public int? Registration { get; set; } = null;
        public bool Active { get; set; } = true;
    }
}