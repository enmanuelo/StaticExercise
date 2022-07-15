using System;


namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"42 degress fahrenheit is equal to {TempConverter.FahrenheitToCelsius(42.0)} degrees celsius");
            Console.WriteLine($"42 degress celsius is equal to {TempConverter.CelsiusToFahrenheit(42.0)} degrees fahrenheit");
        }
    }
}
