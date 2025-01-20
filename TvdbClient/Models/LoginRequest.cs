using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Tvdb.Models;

/// <summary>
/// Http Request for logging in and receiving a token
/// </summary>
public class LoginRequestBody : AbstractBaseRecord
{
    /// <summary>
    /// Api Key
    /// </summary>
    [JsonPropertyName("apikey")]
    [Required(AllowEmptyStrings = true)]
    public string Apikey { get; set; }

    /// <summary>
    /// Subscription Pin (optional)
    /// </summary>
    [JsonPropertyName("pin")]
    public string Pin { get; set; }
}