using System;
using System.Text;
using System.Text.Json;
using Xunit;

namespace Tvdb.Converters;
    public class TimeOnlyConverterTests
    {
        [Fact]
        public void Read_ValidTime_ReturnsTimeOnly()
        {
            // Arrange
            var json = "\"14:30:00\"";
            var reader = new Utf8JsonReader(Encoding.UTF8.GetBytes(json));
            var converter = new TimeOnlyConverter(null);

            // Act
            reader.Read();
            var result = converter.Read(ref reader, typeof(TimeOnly?), new JsonSerializerOptions());

            // Assert
            Assert.NotNull(result);
            Assert.Equal(new TimeOnly(14, 30, 0), result);
        }

        [Fact]
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
            Assert.Null(result);
        }

        [Fact]
        public void Write_ValidTime_WritesCorrectJson()
        {
            // Arrange
            var value = new TimeOnly(14, 30, 0);
            var options = new JsonSerializerOptions { Converters = { new TimeOnlyConverter(null) } };
            var expectedJson = "\"14:30:00\"";

            // Act
            var json = JsonSerializer.Serialize(value, options);

            // Assert
            Assert.Equal(expectedJson, json);
        }

        [Fact]
        public void Write_Null_WritesEmptyString()
        {
            // Arrange
            TimeOnly? value = null;
            var options = new JsonSerializerOptions { Converters = { new TimeOnlyConverter(null) } };
            var expectedJson = "null";

            // Act
            var json = JsonSerializer.Serialize(value, options);

            // Assert
            Assert.Equal(expectedJson, json);
        }
    }