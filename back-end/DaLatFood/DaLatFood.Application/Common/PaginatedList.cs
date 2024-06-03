namespace DaLatFood.Application.Common;

public class PaginatedList<TListDto>
{
    public PaginatedList(List<TListDto> items, int total)
    {
        this.Items = items;
        this.Total = total;
    }

    public List<TListDto>? Items { get; }
    public int Total { get; } = 0;
}