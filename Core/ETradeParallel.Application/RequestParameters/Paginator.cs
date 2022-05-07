namespace ETradeParallel.Application.RequestParameters
{
    public record Paginator
    {
        public int Page { get; set; }
        public int Size { get; set; }
    }
}
