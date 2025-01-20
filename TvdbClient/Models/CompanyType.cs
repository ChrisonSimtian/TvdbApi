namespace Tvdb.Models;

/// <summary>
/// A company type record
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class CompanyType : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("companyTypeId")]
    public int? CompanyTypeId { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("companyTypeName")]
    public string CompanyTypeName { get; set; }
}