using System.Text.Json.Serialization;

namespace Tvdb.Models;

/// <summary>
/// people type record
/// </summary>
public class PeopleType : AbstractBaseRecord
{
    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public long? Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }
}