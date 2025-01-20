using System.Text.Json.Serialization;

namespace Tvdb.Models;

/// <summary>
/// extended award record
/// </summary>
public class AwardExtendedRecord : AwardBaseRecord
{

    [JsonPropertyName("categories")]
    public ICollection<AwardCategoryBaseRecord> Categories { get; set; }

    [JsonPropertyName("score")]
    public long? Score { get; set; }
}