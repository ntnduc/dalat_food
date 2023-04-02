using DaLatFood.Domain.Core;

namespace DaLatFood.Domain.File.Entity;

public class FileEntry : Entity<Guid>
{
    public string RootFolder { get; set; }
    public string Name { get; set; }
    public string Descriptions { get; set; }
    public int Size { get; set; }
    public DateTime UploadedTime { get; set; }
    public string FileName { get; set; }
    public string FileLocation { get; set; }
    public string EntityType { get; set; }
    public string EntityId { get; set; }
}