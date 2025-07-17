namespace Tvdb.Models;

/// <summary>
/// A company relationship
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class CompanyRelationShip : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public int? Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("typeName")]
    public string TypeName { get; set; }
}