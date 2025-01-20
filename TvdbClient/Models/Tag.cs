namespace Tvdb.Models;

/// <summary>
/// tag record
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class Tag : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("allowsMultiple")]
    public bool? AllowsMultiple { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("helpText")]
    public string HelpText { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public long? Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("options")]
    public System.Collections.Generic.ICollection<TagOption> Options { get; set; }
}