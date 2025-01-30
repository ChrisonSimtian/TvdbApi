using System.Text.Json.Serialization;

namespace Tvdb.Models;

/// <summary>
/// extended season record
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NSwag", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SeasonExtendedRecord : SeasonBaseRecord
{

    [JsonPropertyName("artwork")]
    public ICollection<ArtworkBaseRecord> Artwork { get; set; }

    [JsonPropertyName("episodes")]
    public ICollection<EpisodeBaseRecord> Episodes { get; set; }

    [JsonPropertyName("trailers")]
    public ICollection<Trailer> Trailers { get; set; }

    [JsonPropertyName("tagOptions")]
    public ICollection<TagOption> TagOptions { get; set; }

    [JsonPropertyName("translations")]
    public ICollection<Translation> Translations { get; set; }
}