namespace ActivityTracker.Domain.Entities;

public class Image
{
    public Guid Id { get; set; }
    public string Url { get; set; }
    public Guid? ActivityId { get; set; }
    public Guid? UserId { get; set; }
    public DateTime? UploadedAt { get; set; }
}
