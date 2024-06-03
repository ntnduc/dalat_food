namespace DaLatFood.Domain.Core;

public interface IEntity<TKey>
{
    TKey Id { get; set; }
}