using System.Text.Json.Serialization;

namespace Tvdb.Models;

/// <summary>
/// entity update record
/// </summary>
public partial class EntityUpdate : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("entityType")]
    public string EntityType { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("methodInt")]
    public int? MethodInt { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("method")]
    public string Method { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("extraInfo")]
    public string ExtraInfo { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("userId")]
    public int? UserId { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("recordType")]
    public string RecordType { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("recordId")]
    public long? RecordId { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("timeStamp")]
    public long? TimeStamp { get; set; }

    /// <summary>
    /// Only present for episodes records
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("seriesId")]
    public long? SeriesId { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("mergeToId")]
    public long? MergeToId { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("mergeToEntityType")]
    public string MergeToEntityType { get; set; }
}