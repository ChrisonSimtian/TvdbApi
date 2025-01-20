namespace Tvdb.Models;

/// <summary>
/// Favorites record
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class FavoriteRecord : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("series")]
    public int? Series { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("movie")]
    public int? Movie { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("episode")]
    public int? Episode { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("artwork")]
    public int? Artwork { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("people")]
    public int? People { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("list")]
    public int? List { get; set; }
}