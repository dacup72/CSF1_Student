using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3
{
	internal class WaterLab
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Water Lab");

			/*
             * Write a program that will:
             * 
             *      - Assume that a gallon of water weighs 8.33 pounds
             *      - Prompt the user to enter a number of gallons
             *      - Display the total weight of the water in pounds
             *      
             * Test with something simple like 2 to start.
             */

			Console.Write("Enter a number of gallons: ");
			decimal userGallons = decimal.Parse(Console.ReadLine());

			decimal waterWeight = userGallons * 8.33m;

			Console.WriteLine($"That weighs {waterWeight:n2} pounds.");
		}//end Main()
	}//end Class
}//end Namespace
