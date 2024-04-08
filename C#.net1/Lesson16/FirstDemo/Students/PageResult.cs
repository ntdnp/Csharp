namespace FirstDemo.Students
{
    public class PageResult<TViewModel>
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public List<TViewModel> Data { get; set; }

        public int TotalPage
        {
            get
            {
                return TotalCount / PageSize + (TotalCount % PageSize == 0 ? 0 : 1);
            }
        }

    }
}
