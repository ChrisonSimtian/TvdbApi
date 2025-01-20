namespace Tvdb.Models;

/// <summary>
/// base artwork record
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ArtworkBaseRecord : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("height")]
    public long? Height { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public int? Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("image")]
    public string Image { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("includesText")]
    public bool? IncludesText { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("language")]
    public string Language { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("score")]
    public double? Score { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("thumbnail")]
    public string Thumbnail { get; set; }

    /// <summary>
    /// The artwork type corresponds to the ids from the /artwork/types endpoint.
    /// </summary>

    [System.Text.Json.Serialization.JsonPropertyName("type")]
    public long? Type { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("width")]
    public long? Width { get; set; }
}