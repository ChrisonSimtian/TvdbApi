﻿using System.Text.Json.Serialization;

namespace Tvdb.Models;

/// <summary>
/// extended award category record
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NSwag", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AwardCategoryExtendedRecord : AwardCategoryBaseRecord
{
    [JsonPropertyName("nominees")]
    public ICollection<AwardNomineeBaseRecord> Nominees { get; set; }
}