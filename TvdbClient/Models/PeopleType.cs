using System.Text.Json.Serialization;

namespace Tvdb.Models;

/// <summary>
/// people type record
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public class PeopleType : AbstractBaseRecord
{
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}