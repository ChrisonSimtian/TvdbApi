using System;
using System.Text;
using System.Text.Json;

namespace Tvdb.Converters;

public class DateTimeConverterTests
{
    [Test]
    [Arguments(2023, 10, 10, 12, 34, 56)]
    public void Read_ValidDate_ReturnsDateTime(int year, int month, int day, int hour, int minute, int second)
    {
        // Arrange
        var json = $"\"{year:0000}-{month:00}-{day:00} {hour:00}:{minute:00}:{second:00}\"";
        var reader = new Utf8JsonReader(Encoding.UTF8.GetBytes(json));
        var converter = new DateTimeConverter();

        // Act
        reader.Read();
        var result = converter.Read(ref reader, typeof(DateTime?), new JsonSerializerOptions());

        // Assert
        DateTime expectedDate = new(year, month, day, hour, minute, second);
        result.ShouldBe(expectedDate);
    }

    [Test]
    public void Read_NullOrEmptyString_ReturnsNull()
    {
        // Arrange
        var json = "\"\"";
        var reader = new Utf8JsonReader(Encoding.UTF8.GetBytes(json));
        var converter = new DateTimeConverter();

        // Act
        reader.Read();
        var result = converter.Read(ref reader, typeof(DateTime?), new JsonSerializerOptions());

        // Assert
        result.ShouldBeNull();
    }

    [Test]
    public void Write_ValidDate_WritesCorrectJson()
    {
        // Arrange
        var options = new JsonSerializerOptions { Converters = { new DateTimeConverter() } };
        var dateTime = new DateTime(2023, 10, 10, 12, 34, 56);

        // Act
        var json = JsonSerializer.Serialize(dateTime, options);

        // Assert
        json.ShouldBe("\"2023-10-10T12:34:56\"");
    }

    [Test]
    public void Write_NullValue_WritesEmptyString()
    {
        // Arrange
        var options = new JsonSerializerOptions { Converters = { new DateTimeConverter() } };
        DateTime? dateTime = null;

        // Act
        var json = JsonSerializer.Serialize(dateTime, options);

        // Assert
        json.ShouldBe("null");
    }
}