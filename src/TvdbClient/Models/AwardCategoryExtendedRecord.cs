using System.Text.Json.Serialization;

namespace Tvdb.Models;

/// <summary>
/// extended award category record
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public class AwardCategoryExtendedRecord : AwardCategoryBaseRecord
{
    [JsonPropertyName("nominees")]
    public ICollection<AwardNomineeBaseRecord> Nominees { get; set; }
}