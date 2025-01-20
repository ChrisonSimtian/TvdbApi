namespace Tvdb.Models;

/// <summary>
/// language record
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class Language : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public string Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("nativeName")]
    public string NativeName { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("shortCode")]
    public string ShortCode { get; set; }
}