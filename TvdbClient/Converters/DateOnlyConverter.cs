using System.Text.Json;
using System.Text.Json.Serialization;

namespace Tvdb.Converters;

/// <summary>
/// <see cref="DateOnly"/> Converter for TVDB
/// </summary>
public class DateOnlyConverter(string? serializationFormat) : JsonConverter<DateOnly?>
{
    private readonly string serializationFormat = serializationFormat ?? dateFormat;
    private const string dateFormat = "yyyy-MM-dd";

    #region Constructor
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public DateOnlyConverter() : this(null) { }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    #endregion

    #region Methods
    /// <inheritdoc/>
    public override DateOnly? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        if (string.IsNullOrEmpty(value)) return default;
        return DateOnly.Parse(value!);
    }

    /// <inheritdoc/>
    public override void Write(Utf8JsonWriter writer, DateOnly? value, JsonSerializerOptions options)
        => writer.WriteStringValue(value.HasValue ? value.Value.ToString(serializationFormat) : string.Empty);
    #endregion
}