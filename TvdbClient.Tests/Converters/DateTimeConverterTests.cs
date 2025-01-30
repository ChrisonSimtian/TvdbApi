using System;
using System.Text;
using System.Text.Json;

namespace Tvdb.Converters;
    public class DateTimeConverterTests
    {
        [Fact]
        public void Read_ValidDate_ReturnsDateTime()
        {
            // Arrange
            var json = "\"2023-10-10 12:34:56\"";
            var reader = new Utf8JsonReader(Encoding.UTF8.GetBytes(json));
            var converter = new DateTimeConverter();

            // Act
            reader.Read();
            var result = converter.Read(ref reader, typeof(DateTime?), new JsonSerializerOptions());

            // Assert
            Assert.Equal(new DateTime(2023, 10, 10, 12, 34, 56), result);
        }

        [Fact]
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
            Assert.Null(result);
        }

        [Fact]
        public void Write_ValidDate_WritesCorrectJson()
        {
            // Arrange
            var options = new JsonSerializerOptions { Converters = { new DateTimeConverter() } };
            var dateTime = new DateTime(2023, 10, 10, 12, 34, 56);

            // Act
            var json = JsonSerializer.Serialize(dateTime, options);

            // Assert
            Assert.Equal("\"2023-10-10T12:34:56\"", json);
        }

        [Fact]
        public void Write_NullValue_WritesEmptyString()
        {
            // Arrange
            var options = new JsonSerializerOptions { Converters = { new DateTimeConverter() } };
            DateTime? dateTime = null;

            // Act
            var json = JsonSerializer.Serialize(dateTime, options);

            // Assert
            Assert.Equal("null", json);
        }
    }