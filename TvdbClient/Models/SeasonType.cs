﻿namespace Tvdb.Models;

/// <summary>
/// season type record
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class SeasonType : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("alternateName")]
    public string AlternateName { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public long? Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("type")]
    public string Type { get; set; }
}