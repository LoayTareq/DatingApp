using System.Text.Json.Serialization;

namespace API.Entities;

public class Photo
{
    public int Id { get; set; }
    public required string Url { get; set; }
    public string? PublicId { get; set; }

    //nav prop
    [JsonIgnore]
    public Member Member { get; set; } = null!;

    public string MemberId { get; set; } = null!;
}
