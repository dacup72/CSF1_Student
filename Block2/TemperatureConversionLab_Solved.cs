using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Block2
{
	class TemperatureConversionLabSolved
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Converting Temperatures");

			Console.WriteLine("Celsius to Fahrenheit");

			decimal celTemp = 100m;
			Console.WriteLine("The temperature in Celsius is " + celTemp + ".");

			decimal fahTemp = celTemp * (9.0m / 5.0m) + 32;
			Console.WriteLine("The temperature in Fahrenheit is " + fahTemp + ".");

			Console.WriteLine("Fahrenheit to Celsius");

			decimal fahTemp2 = 98.6m;
			Console.WriteLine("The temperature in Fahrenheit is " + fahTemp2 + ".");

			decimal celTemp2 = 5m / 9m * (fahTemp2 - 32m);
			Console.WriteLine("The temperature in Celsius is " + celTemp2 + ".");

		} //end method
	}//end class
}//end namespace
