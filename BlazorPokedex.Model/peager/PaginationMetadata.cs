namespace BlazorPokedex.Model.peager
{
    public class PaginationMetadata
    {
        public int CurrentPage { get; set; } = 1;
        public int TotalPages { get; set; }
        public int Items { get; set; }
        public bool HasPrevios { get => CurrentPage > 1;}
        public bool HasNext { get => CurrentPage < TotalPages; }
    }
}
