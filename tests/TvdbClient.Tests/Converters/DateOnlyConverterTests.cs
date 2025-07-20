using System;
using System.Text;
using System.Text.Json;

namespace Tvdb.Converters;

public class DateOnlyConverterTests
{
    [Test]
    public void Read_ValidDate_ReturnsDateOnly()
    {
        // Arrange
        var json = "\"2023-10-05\"";
        var reader = new Utf8JsonReader(Encoding.UTF8.GetBytes(json));
        var converter = new DateOnlyConverter(null);

        // Act
        reader.Read();
        var result = converter.Read(ref reader, typeof(DateOnly?), new JsonSerializerOptions());

        // Assert
        result.ShouldNotBeNull();
        result.ShouldBeOfType<DateOnly>();
        // Validate the date
        result.ShouldBe(new DateOnly(2023, 10, 5));
    }

    [Test]
    public void Read_NullOrEmpty_ReturnsNull()
    {
        // Arrange
        var json = "\"\"";
        var reader = new Utf8JsonReader(Encoding.UTF8.GetBytes(json));
        var converter = new DateOnlyConverter(null);

        // Act
        reader.Read();
        var result = converter.Read(ref reader, typeof(DateOnly?), new JsonSerializerOptions());

        // Assert
        result.ShouldBeNull();
    }

    [Test]
    public void Write_ValidDate_WritesCorrectJson()
    {
        // Arrange
        var value = new DateOnly(2023, 10, 5);
        var options = new JsonSerializerOptions { Converters = { new DateOnlyConverter(null) } };
        var expectedJson = "\"2023-10-05\"";

        // Act
        var json = JsonSerializer.Serialize(value, options);

        // Assert
        json.ShouldBeEquivalentTo(expectedJson);
    }

    [Test]
    public void Write_Null_WritesEmptyString()
    {
        // Arrange
        DateOnly? value = null;
        var options = new JsonSerializerOptions { Converters = { new DateOnlyConverter(null) } };
        var expectedJson = "null";

        // Act
        var json = JsonSerializer.Serialize(value, options);

        // Assert
        json.ShouldBeEquivalentTo(expectedJson);
    }
}