using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MoviesMVC.Converters
{
    public class StringToIntConverter : JsonConverter<int>
    {
        public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int result = 0;

            bool check = Int32.TryParse(reader.GetString()!, out result);

            return check ? result : -1;
        }

        public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
