using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tvdb.Extensions;

namespace Tvdb.Models;

/// <summary>
/// Bearer Token Model
/// </summary>
public class Token
{
    /// <summary>
    /// Bearer Token
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("token")]
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    public string AccessToken { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

    /// <summary>
    /// Timestamp of Creation
    /// </summary>
    public DateTime CreationTimestamp { get; } = DateTime.Now;

    /// <summary>
    /// Expiry Date
    /// </summary>
    /// <remarks>TVDB says their tokens last a month</remarks>
    [System.Text.Json.Serialization.JsonIgnore]
    public DateTime TokenExpiryDate => CreationTimestamp.AddDays(30);

    /// <summary>
    /// Has this Token expired?
    /// </summary>
    [System.Text.Json.Serialization.JsonIgnore]
    public bool IsTokenExpired => TokenExpiryDate.IsInThePast();

    /// <summary>
    /// Token Type
    /// </summary>
    /// <remarks>Hardcoded Bearer even though its not quite a Bearer Token but ok</remarks>
    public static string TokenType => "Bearer";
}