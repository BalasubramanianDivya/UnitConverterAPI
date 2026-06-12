# Unit Converter API

## Overview

A RESTful ASP.NET Core Web API that converts values between different units of measurement.

Categories used:

* Length
* Weight
* Temperature

---

## Technologies Used

* ASP.NET Core (.NET 10)
* C#
* Swagger

---

## Supported Units

### Length

* millimeter (mm)
* centimeter (cm)
* meter (m)
* kilometer (km)
* inch (in)
* foot (ft)
* mile (mi)

### Weight

* milligram (mg)
* gram (g)
* kilogram (kg)
* pound (lb)

### Temperature

* Celsius (c)
* Fahrenheit (f)
* Kelvin (k)

---

## To run the application locally

### Prerequisites

* .NET 10 SDK
* Visual Studio 2026

### Steps

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Restore NuGet packages.
4. Build the solution.
5. Click Run

Swagger UI will be available at:

[https://localhost:{port}/swagger](https://localhost:{port}/swagger)

---

## Example - Request

POST /api/UnitConverter/convert

```json
{
  "category": "length",
  "fromUnit": "cm",
  "toUnit": "m",
  "value": 100
}
```

Example - Response

```json
{
  "originalValue": 100,
  "fromUnit": "cm",
  "toUnit": "m",
  "convertedValue": 1
}
```

---
## API Screenshots

### Swagger UI

![Swagger UI](Unit_Converter_API/Screenshots/HomePage.png)

### Length Conversion Example

![Length Conversion](Unit_Converter_API/Screenshots/length_conv.png)
![Length Result](Unit_Converter_API/Screenshots/length_res.png)

### Weight Conversion Example

![Weight Conversion](Unit_Converter_API/Screenshots/Weight_conversion.png)
![Weight Result](Unit_Converter_API/Screenshots/weight_res.png)

### Temperature Conversion Example

![Temperature Conversion](Unit_Converter_API/Screenshots/temp_conv.png)
![Temperature Result](Unit_Converter_API/Screenshots/temp_res.png)
