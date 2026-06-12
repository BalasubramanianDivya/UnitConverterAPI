namespace Unit_Converter_API.Services
{
    public class UnitConversion_Service
    {
        public double Convert(string category,
                              string fromUnit,
                              string toUnit,
                              double value)
        {
            category = category.ToLower();

            fromUnit = NormalizeUnit(fromUnit);
            toUnit = NormalizeUnit(toUnit);

            return category switch
            {
                "length" => ConvertLength(fromUnit, toUnit, value),
                "weight" => ConvertWeight(fromUnit, toUnit, value),
                "temperature" => ConvertTemperature(fromUnit, toUnit, value),
                _ => throw new Exception("Unsupported category")
            };
        }

        private string NormalizeUnit(string unit)
        {
            return unit.ToLower() switch
            {
                // Length
                "mm" => "millimeter",
                "cm" => "centimeter",
                "m" => "meter",
                "km" => "kilometer",
                "in" => "inch",
                "ft" => "foot",
                "mi" => "mile",

                // Weight
                "mg" => "milligram",
                "g" => "gram",
                "kg" => "kilogram",
                "lb" => "pound",
                "lbs" => "pound",

                // Temperature
                "c" => "celsius",
                "f" => "fahrenheit",
                "k" => "kelvin",

                _ => unit.ToLower()
            };
        }

        private double ConvertLength(string from, string to, double value)
        {
            var factors = new Dictionary<string, double>
            {
                { "millimeter", 0.001 },
                { "centimeter", 0.01 },
                { "meter", 1 },
                { "kilometer", 1000 },
                { "inch", 0.0254 },
                { "foot", 0.3048 },
                { "mile", 1609.34 }
            };

            if (!factors.ContainsKey(from) || !factors.ContainsKey(to))
                throw new Exception("Invalid length unit");

            double meters = value * factors[from];

            return meters / factors[to];
        }

        private double ConvertWeight(string from, string to, double value)
        {
            var factors = new Dictionary<string, double>
            {
                { "milligram", 0.000001 },
                { "gram", 0.001 },
                { "kilogram", 1 },
                { "pound", 0.453592 },
                { "ton", 1000 }
            };

            if (!factors.ContainsKey(from) || !factors.ContainsKey(to))
                throw new Exception("Invalid weight unit");

            double kilograms = value * factors[from];

            return kilograms / factors[to];
        }

        private double ConvertTemperature(string from,
                                          string to,
                                          double value)
        {
            if (from == to)
                return value;

            // Celsius conversions
            if (from == "celsius" && to == "fahrenheit")
                return (value * 9 / 5) + 32;

            if (from == "celsius" && to == "kelvin")
                return value + 273.15;

            // Fahrenheit conversions
            if (from == "fahrenheit" && to == "celsius")
                return (value - 32) * 5 / 9;

            if (from == "fahrenheit" && to == "kelvin")
                return ((value - 32) * 5 / 9) + 273.15;

            // Kelvin conversions
            if (from == "kelvin" && to == "celsius")
                return value - 273.15;

            if (from == "kelvin" && to == "fahrenheit")
                return ((value - 273.15) * 9 / 5) + 32;

            throw new Exception("Unsupported temperature conversion");
        }
    }
}