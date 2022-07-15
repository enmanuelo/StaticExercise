using System;
namespace StaticExercise
{
	public static class TempConverter
	{
		static TempConverter()
		{
		}

		public static double FahrenheitToCelsius(double fTemp)
        {			
			double cTemp = (fTemp - 32) * (5.0/9.0);

			return cTemp;
        }

		public static double CelsiusToFahrenheit(double cTemp)
        {
			double fTemp = (cTemp * (9.0 / 5.0)) + 32.0;

			return fTemp;
        }
	}
}
