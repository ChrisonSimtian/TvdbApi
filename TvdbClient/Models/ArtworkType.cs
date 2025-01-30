namespace Tvdb.Models;

/// <summary>
/// artwork type record
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ArtworkType : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("height")]
    public long? Height { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public long? Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("imageFormat")]
    public string ImageFormat { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("recordType")]
    public string RecordType { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("slug")]
    public string Slug { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("thumbHeight")]
    public long? ThumbHeight { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("thumbWidth")]
    public long? ThumbWidth { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("width")]
    public long? Width { get; set; }
}