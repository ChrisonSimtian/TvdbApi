namespace Tvdb.Models;

/// <summary>
/// User favorites record
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class Favorites : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("series")]
    public System.Collections.Generic.ICollection<int> Series { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("movies")]
    public System.Collections.Generic.ICollection<int> Movies { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("episodes")]
    public System.Collections.Generic.ICollection<int> Episodes { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("artwork")]
    public System.Collections.Generic.ICollection<int> Artwork { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("people")]
    public System.Collections.Generic.ICollection<int> People { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("lists")]
    public System.Collections.Generic.ICollection<int> Lists { get; set; }
}