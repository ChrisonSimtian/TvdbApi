namespace Tvdb.Models;

/// <summary>
/// A company type record
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CompanyType : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("companyTypeId")]
    public int? CompanyTypeId { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("companyTypeName")]
    public string CompanyTypeName { get; set; }
}