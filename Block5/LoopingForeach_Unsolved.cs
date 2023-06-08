using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block5
{
	internal class LoopingForeachUnsolved
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Looping Foreach");
			Console.Title = "-==== LOOPING WITH FOREACH ====-";

			/* FOREACH is a specialized loop made for collections.
             * You can see the values in the collection, but you
             * can NOT change them in a foreach.
             * 
             * foreach (DATATYPE MADEUPNAME in COLLECTION)
             * {
             *      //code to run with MADEUPNAME
             * }
             * 
             * This is the easiest, least error-prone loop. 
             * It is preferred in many program contexts,
             * but we lose some flexibility with it.
             * 
             * The foreach-loop is versatile.
             * We will end up using them in strings,
             * string arrays, and even DataTables.
             */

			string[] colors = { "red", "blue", "green", "purple",
							  "black", "pink"};

			foreach (string color in colors)
			{
				Console.WriteLine(color);
			}//end foreach


			int[] gradeScores = { 100, 80, 42, 75, 2 };

			foreach (int bob in gradeScores)
			{
				Console.WriteLine(bob);
			}//end foreach

			//Print out each of the prices in the below array to the screen with currency formatting:

			decimal[] cartPrices = { 12.99m, 2, 9.99m, 10, 20 };

			//print out each price with a foreach structure
			foreach (decimal price in cartPrices)
			{
				Console.WriteLine("{0:c}", price);
			}//end foreach


			//Let's total up all of the prices in the cart.
			//Create a running total variable so we can
			//print out the total AFTER the foreach.

			decimal totalSale = 0;//always give a running total variable
								  //some default (starting) value

			Console.WriteLine("\nThank you for purchasing from WeRProgrammers\n");

			foreach (decimal price in cartPrices)
			{
				//totalSale = totalSale + price;
				totalSale += price;
				//either of the above works.. but only choose one...
				Console.WriteLine("After adding {0:c}, the total is now: {1:c}",
					price, totalSale);

			}//end foreach

			Console.WriteLine("\nYour total purchase is: {0:c}", totalSale);

			//Remember, a string is a collection of characters
			string letters = "abcdefghijklmnopqrstuvwxyz";

			foreach (char letter in letters)
			{
				Console.WriteLine(letter);
			}

			Console.WriteLine(letters.Length + " total letters");
		}//end Main()
	}//end Class
}//end Namespace
