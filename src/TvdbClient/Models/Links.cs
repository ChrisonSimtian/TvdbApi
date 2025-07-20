using System.Text.Json.Serialization;

namespace Tvdb.Models;

/// <summary>
/// Links for next, previous and current record
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public class Links
{
    /// <summary>
    /// Link to the previous page
    /// </summary>
    [JsonPropertyName("prev")]
    public string PreviousPage { get; set; }

    /// <summary>
    /// Link to the current page
    /// </summary>
    [JsonPropertyName("self")]
    public string Self { get; set; }

    /// <summary>
    /// Link to the next page
    /// </summary>
    [JsonPropertyName("next")]
    public string NextPage { get; set; }

    /// <summary>
    /// Total number of items
    /// </summary>
    [JsonPropertyName("total_items")]
    public int? ItemCount { get; set; }

    /// <summary>
    /// Number of Items per Page
    /// </summary>
    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }

    /// <summary>
    /// backing field for <see cref="AdditionalProperties"/>"/>
    /// </summary>
    private IDictionary<string, object>? _additionalProperties;

    /// <summary>
    /// Contains additional Properties that havent been mapped yet
    /// </summary>
    [JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get => _additionalProperties ??= new Dictionary<string, object>();
        set => _additionalProperties = value;
    }
}