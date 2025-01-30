namespace Tvdb.Models;

/// <summary>
/// A company record
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class Company : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("activeDate")]
    public string ActiveDate { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("aliases")]
    public System.Collections.Generic.ICollection<Alias> Aliases { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("country")]
    public string Country { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public long? Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("inactiveDate")]
    public string InactiveDate { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("nameTranslations")]
    public System.Collections.Generic.ICollection<string> NameTranslations { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("overviewTranslations")]
    public System.Collections.Generic.ICollection<string> OverviewTranslations { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("primaryCompanyType")]
    public long? PrimaryCompanyType { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("slug")]
    public string Slug { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("parentCompany")]
    public ParentCompany ParentCompany { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("tagOptions")]
    public System.Collections.Generic.ICollection<TagOption> TagOptions { get; set; }
}