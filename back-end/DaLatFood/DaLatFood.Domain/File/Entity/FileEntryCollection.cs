using DaLatFood.Domain.Core;

namespace DaLatFood.Domain.File.Entity;

public class FileEntryCollection : Entity<Guid>
{
    public Guid CreatedBy { get; set; }
    public DateTime CreatedTime { get; set; }
    public Guid? LastModifiedBy { get; set; }
    public DateTime? LastModifiedTime { get; set; }
}