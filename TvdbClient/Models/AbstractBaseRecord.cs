namespace Tvdb.Models;

/// <summary>
/// Base Record for all TVDB Records
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NSwag", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public abstract class AbstractBaseRecord
{
    /// <summary>
    /// backing field for <see cref="AdditionalProperties"/>"/>
    /// </summary>
    private IDictionary<string, object>? _additionalProperties;

    /// <summary>
    /// Contains additional Properties that havent been mapped yet
    /// </summary>
    [System.Text.Json.Serialization.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get => _additionalProperties ??= new Dictionary<string, object>();
        set => _additionalProperties = value;
    }
}
