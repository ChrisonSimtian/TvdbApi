﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tvdb.Configuration;

/// <summary>
/// Configuration for the TVDB Client
/// </summary>
public class TvdbConfiguration
{
    /// <summary>
    /// TVDB Api Key
    /// </summary>

    public virtual string ApiKey { get; set; }

    /// <summary>
    /// Optional: TVDB Subscriber Pin
    /// </summary>
    public virtual string? Pin { get; set; }

    /// <summary>
    /// Base URL for the API
    /// </summary>
    public virtual string BaseUrl { get; set; }

    /// <summary>
    /// Url for the Token Generation
    /// </summary>
    public string TokenUrl => $"{BaseUrl}/login";
}