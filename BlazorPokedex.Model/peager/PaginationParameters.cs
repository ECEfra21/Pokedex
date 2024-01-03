namespace BlazorPokedex.Model.peager
{
    public class PaginationParameters
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public int Offset { get => (PageNumber -1 )* PageSize; }
    }
}
