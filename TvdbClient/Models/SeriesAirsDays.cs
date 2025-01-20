namespace Tvdb.Models;

/// <summary>
/// A series airs day record
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class SeriesAirsDays : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("friday")]
    public bool? Friday { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("monday")]
    public bool? Monday { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("saturday")]
    public bool? Saturday { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("sunday")]
    public bool? Sunday { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("thursday")]
    public bool? Thursday { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("tuesday")]
    public bool? Tuesday { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("wednesday")]
    public bool? Wednesday { get; set; }
}