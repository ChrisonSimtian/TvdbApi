namespace Tvdb.Models;

/// <summary>
/// base award category record
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class AwardCategoryBaseRecord : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("allowCoNominees")]
    public bool? AllowCoNominees { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("award")]
    public AwardBaseRecord Award { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("forMovies")]
    public bool? ForMovies { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("forSeries")]
    public bool? ForSeries { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public long? Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }
}