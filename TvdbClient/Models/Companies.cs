namespace Tvdb.Models;

/// <summary>
/// Companies by type record
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class Companies : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("studio")]
    public System.Collections.Generic.ICollection<Company> Studio { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("network")]
    public System.Collections.Generic.ICollection<Company> Network { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("production")]
    public System.Collections.Generic.ICollection<Company> Production { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("distributor")]
    public System.Collections.Generic.ICollection<Company> Distributor { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("special_effects")]
    public System.Collections.Generic.ICollection<Company> Special_effects { get; set; }
}