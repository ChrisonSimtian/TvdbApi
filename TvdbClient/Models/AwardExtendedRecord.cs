using System.Text.Json.Serialization;

namespace Tvdb.Models;

/// <summary>
/// extended award record
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NSwag", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AwardExtendedRecord : AwardBaseRecord
{

    [JsonPropertyName("categories")]
    public ICollection<AwardCategoryBaseRecord> Categories { get; set; }

    [JsonPropertyName("score")]
    public long? Score { get; set; }
}