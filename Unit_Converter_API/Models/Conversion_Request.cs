using System.ComponentModel.DataAnnotations;

namespace Unit_Converter_API.Models
{
    public class Conversion_Request
    {
        [Required]
        public string Category { get; set; } = string.Empty;

        [Required]
        public string FromUnit { get; set; } = string.Empty;

        [Required]
        public string ToUnit { get; set; } = string.Empty;

        [Required]
        public double Value { get; set; }
    }
}