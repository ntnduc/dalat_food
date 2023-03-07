namespace DaLatFood.Domain.Core.CommonModel;

public class PaginatedListQuery
{
    public int Offset { get; set; }
    public int Limit { get; set; }
    public string SearchKey { get; set; }
    public Dictionary<string, string> Sort { get; set; }
}