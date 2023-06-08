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
			// Loop through the array to print out all items
			// ==================== INSERT CODE BELOW ====================




			int[] gradeScores = { 100, 80, 42, 75, 2 };
			// Loop through the array to print out all items
			// ==================== INSERT CODE BELOW ====================



			

			//Print out each of the prices in the below array to the screen with currency formatting:
			decimal[] cartPrices = { 12.99m, 2, 9.99m, 10, 20 };
			// ==================== INSERT CODE BELOW ====================




			//Let's total up all of the prices in the cart.
			//Create a running total variable so we can
			//print out the total AFTER the foreach.
			// ==================== INSERT CODE BELOW ====================






			//Remember, a string is a collection of characters
			string letters = "abcdefghijklmnopqrstuvwxyz";
			// Print out each character
			// ==================== INSERT CODE BELOW ====================




		}//end Main()
	}//end Class
}//end Namespace
