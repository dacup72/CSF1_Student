using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block4
{
	class ArraysSolved
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Arrays");

			/*
             * An array stores a fixed-size sequential collection of 
             * objects of the same type. 
             * 
             * An array is used to store a collection of 
             * data, but it is often more useful to think of an array as 
             * a collection of variables of the same type.
             * 
             * Standard Arrays: 
             * 
             * - Have a fixed size (can't change it programmatically)
             * - The size is called the Length (1-based counting)
             * - Uses 0-based counting for the positions of the indexes.
             * - Type safe
             * - Use the "new" keyword to call the "constructor" that builds the object
             */

			//One way to create an array:
			//declare with a set Length (1-based counting!)
			string[] dresser = new string[4];
			//created a string array named dresser and assigned it
			//the Length of 4.

			//Now initialize the values individually.
			//You must initialize them before you can use them.
			//You can initialize them in any order.
			dresser[0] = "shirts"; //in the drawer, with an index of 0, put "shirts"
			dresser[1] = "pants";
			dresser[3] = "socks";
			dresser[2] = "shorts";

			//Each of the indexes called by dresser[indexNumber]
			//is a variable that you can use in your program.

			Console.WriteLine("{0} are in the drawer with an index of 2",
				dresser[2]);

			//Write the last index to the screen using string interpolation
			Console.WriteLine($"{dresser[3]} is in the last drawer.");

			//you can reassign the drawers (indexes) of an array just like normal variables. 
			dresser[3] = "t-shirts";

			Console.WriteLine("{0} is in the 4th drawer with an index of 3", dresser[3]);

			Console.WriteLine("{0} is in index 1 and {1} is in index 2", dresser[1], dresser[2]);

			//To explore an object in intellisense use a period.
			Console.WriteLine(dresser.Length + " is the Length of the array");

			//The first index is always 0
			Console.WriteLine("The first item is " + dresser[0]);

			//The last index is always 1 less than the Length
			Console.WriteLine("The last item is " + dresser[dresser.Length - 1]);

			//Another array, created the long way.
			//The long way is best if you don't know what all you want to put in the boxes.
			//You must still know exactly how many boxes you need!

			decimal[] prices = new decimal[5];
			//Generally, collections have a pluralized name.

			prices[0] = 24.99m;
			prices[1] = 100;
			prices[2] = 50;
			prices[3] = 9.75m;

			//prices[6] = 200;//you will get a runtime error for outside the bounds if you try to access or use an index that can not exist
			prices[4] = 199;

			//Just like the string array, you can write a single index's value to the screen...
			Console.WriteLine(prices[1]);

			//...but you cannot write the entire collection its name
			Console.WriteLine(prices);
			//The compiler does not know how to format complex datatypes by default, so attempting to print a complex datatype tothe screen will usually result in an output of the 
			//namespace.className where the class is defined.

			//You can use them in calculations
			//decimal totalSale = prices[0] + prices[1] + prices[2] + prices[3] + prices[4];
			//but there is a shorter way to do some calculations
			decimal totalSale = prices.Sum();

			Console.WriteLine($"Total sale: {totalSale:c}");

			Console.WriteLine("\nPrices has {0} indexes." +
				"\n1st Index holds {1:c} and the last index holds {2:c}.",
				prices.Length,
				prices[0],
				prices[prices.Length - 1]);

			//Sort() is called from the Array class.  It sorts the indexes of the specified array from lowest to highest value by number or from a-z for alphas. It
			//is referred to as an "ascending sort", as it ascends from the lowest to highest value.
			//Syntax: Array.Sort(arrayToSort)

			Array.Sort(prices);

			Console.WriteLine("\nPrices has {0} indexes. " +
				"\n1st Index holds {1:c} and the last index holds {2:c}",
				prices.Length,
				prices[0],
				prices[prices.Length - 1]);

			Console.WriteLine();

			//To get a descending sort (highest to lowest) there is not a direct method.
			//You have to Sort() the array first and then run Reverse() which just flips the contents of the indexes.

			//As we have already sorted prices, let's reverse it
			Array.Reverse(prices);

			Console.WriteLine("\nPrices has {0} indexes. " +
				"\n1st Index holds {1:c} and the last index holds {2:c}",
				prices.Length,
				prices[0],
				prices[prices.Length - 1]);

			//You can use a shortcut to both declare and initialize an array.
			//You must know all of the values you want to put into the boxes first. This is called "Collection Initialization" syntax
			string[] toolbox = { "wrenches", "screwdrivers", "sockets",
								"hammers"};
			//.The Framework will determine the Length based upon the number of items being
			//initialized and will put them into the indexes in the order provided.

			int number = 42;
			int anotherNumber = 987;

			int[] numbers = { 50, number, 87, anotherNumber, 35, 15 };

			bool[] boolpen = { true, false, true, false };

			//Arrays are part of the Collections family, which we will delve into more next week

			//A string is a collection of chars!
			//As a collection it will have a Length and it will have indexes just like an array. This gives us some useful functionality

			//The Substring method!
			string stringName = "James Bond";
			int location = stringName.IndexOf(" ");
			//the IndexOf() gives us the index location of a char in the string (5 in this case).
			//We could have just as easily picked the IndexOf("B") or IndexOf("a")
			//If there are MORE THAN ONE identical chars it will return the very first one in the string from left to right


			string firstName = stringName.Substring(0, location);
			//We take the starting index and then tell it how many chars to capture after that point
			//We used 0 to 4 in this case, but 0 to 5(location + 1) would have given 
			//us the same output, because the 5th index is a blank space.
			Console.WriteLine(firstName);
			string lastName = stringName.Substring(location + 1);
			Console.WriteLine(lastName);

		}//end Main()
	}//end class
}//end namespace
