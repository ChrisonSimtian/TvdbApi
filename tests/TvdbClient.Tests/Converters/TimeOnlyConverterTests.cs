using System;
using System.Text;
using System.Text.Json;

namespace Tvdb.Converters;

public class TimeOnlyConverterTests
{
    [Test]
    [Arguments(14, 30, 0)]
    public void Read_ValidTime_ReturnsTimeOnly(int hour, int minute, int second)
    {
        // Arrange
        var json = $"\"{hour:00}:{minute:00}:{second:00}\"";
        var reader = new Utf8JsonReader(Encoding.UTF8.GetBytes(json));
        var converter = new TimeOnlyConverter(null);

        // Act
        reader.Read();
        var result = converter.Read(ref reader, typeof(TimeOnly?), new JsonSerializerOptions());

        // Assert
        result.ShouldNotBeNull();
        result.ShouldBeOfType<TimeOnly>();
        result.ShouldBe(new TimeOnly(hour, minute, second));
    }

    [Test]
    public void Read_NullOrEmpty_ReturnsNull()
    {
        // Arrange
        var json = "\"\"";
        var reader = new Utf8JsonReader(Encoding.UTF8.GetBytes(json));
        var converter = new TimeOnlyConverter(null);

        // Act
        reader.Read();
        var result = converter.Read(ref reader, typeof(TimeOnly?), new JsonSerializerOptions());

        // Assert
        result.ShouldBeNull();
    }

    [Test]
    public void Write_ValidTime_WritesCorrectJson()
    {
        // Arrange
        var value = new TimeOnly(14, 30, 0);
        var options = new JsonSerializerOptions { Converters = { new TimeOnlyConverter(null) } };
        var expectedJson = "\"14:30:00\"";

        // Act
        var json = JsonSerializer.Serialize(value, options);

        // Assert
        json.ShouldBeEquivalentTo(expectedJson);
    }

    [Test]
    public void Write_Null_WritesEmptyString()
    {
        // Arrange
        TimeOnly? value = null;
        var options = new JsonSerializerOptions { Converters = { new TimeOnlyConverter(null) } };
        var expectedJson = "null";

        // Act
        var json = JsonSerializer.Serialize(value, options);

        // Assert
        json.ShouldBeEquivalentTo(expectedJson);
    }
}