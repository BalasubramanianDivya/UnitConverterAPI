namespace Unit_Converter_API.Models
{
    public class Conversion_Response
    {
        public double OGValue { get; set; }

        public string FromUnit { get; set; } = string.Empty;

        public string ToUnit { get; set; } = string.Empty;

        public double ConvertedValue { get; set; }
    }
}
