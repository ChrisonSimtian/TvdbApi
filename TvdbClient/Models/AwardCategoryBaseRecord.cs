namespace Tvdb.Models;

/// <summary>
/// base award category record
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
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