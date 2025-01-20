namespace Tvdb.Models;

/// <summary>
/// release record
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class Release : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("country")]
    public string Country { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("date")]
    public string Date { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("detail")]
    public string Detail { get; set; }
}