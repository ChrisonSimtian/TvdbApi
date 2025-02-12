﻿namespace Tvdb.Models;

/// <summary>
/// content rating record
/// </summary>
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class ContentRating : AbstractBaseRecord
{

    [System.Text.Json.Serialization.JsonPropertyName("id")]
    public long? Id { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("name")]
    public string Name { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("description")]
    public string Description { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("country")]
    public string Country { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("contentType")]
    public string ContentType { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("order")]
    public int? Order { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("fullName")]
    public string FullName { get; set; }
}