namespace BlazorPokedex.Model.peager
{
    public class PaginationButton
    {
        public string Text { get; set; }
        public int Page { get; set; }
        public bool Enable { get; set; }
        public bool Active { get; set; }
        public PaginationButton(int page, bool enable, string text)
        {
            Page = page;
            Enable= enable;
            Text = text;
        }
    }
}
