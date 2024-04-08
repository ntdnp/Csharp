namespace FirstDemo.Students
{
    public class SearchQuery
    {
        public int PageIndex { get; set; } //2 lấy 11=> 20 bỏ qua từ 1=> 10
        public int PageSize { get; set; }  //10

        public int SkipNo
        {
            get
            {
                return (PageIndex - 1) * PageSize;
            }
        }

        public int TakeNo
        {
            get
            {
                return PageSize;
            }
        }
        public string Keyword { get; set; }
    }
}
