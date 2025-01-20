namespace Tvdb.Models;

/// <summary>
/// Links for next, previous and current record
/// </summary>
public class Links
{
    /// <summary>
    /// Link to the previous page
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("prev")]
    public string PreviousPage { get; set; }

    /// <summary>
    /// Link to the current page
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("self")]
    public string Self { get; set; }

    /// <summary>
    /// Link to the next page
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("next")]
    public string NextPage { get; set; }

    /// <summary>
    /// Total number of items
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("total_items")]
    public int? ItemCount { get; set; }

    /// <summary>
    /// Number of Items per Page
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("page_size")]
    public int? PageSize { get; set; }

    /// <summary>
    /// backing field for <see cref="AdditionalProperties"/>"/>
    /// </summary>
    private IDictionary<string, object>? _additionalProperties;

    /// <summary>
    /// Contains additional Properties that havent been mapped yet
    /// </summary>
    [System.Text.Json.Serialization.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get => _additionalProperties ??= new Dictionary<string, object>();
        set => _additionalProperties = value;
    }
}