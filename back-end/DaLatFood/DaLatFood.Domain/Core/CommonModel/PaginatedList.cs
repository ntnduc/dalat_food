namespace DaLatFood.Domain.Core.CommonModel;

public class PaginatedList<T>
{
    public int TotalCount { get; set; }
    public int Limit { get; set; }
    public int Offset { get; set; }
    public int TotalPages { get; set; } 
    public int CurrentPage { get; set; }
    public List<T> Items { get; set; }

    public PaginatedList(List<T> items, int totalCount, int offset, int limit)
    {
        this.CurrentPage = (int) Math.Ceiling((double) offset / (double)limit);
        this.TotalPages = (int)Math.Ceiling((double)totalCount / (double)limit);
        this.Offset = offset;
        this.Limit = limit;
        this.Items = items;
    } 
}