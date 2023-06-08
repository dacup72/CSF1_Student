using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block5
{
	class LoopingForSolved
	{
		static void Main(string[] args)
		{

			//! Introduce Console.Title here

			Console.WriteLine("Looping with FOR");
			Console.Title = "-====== LOOPING WITH FOR =====-";

			/*
             * FOR LOOP SYNTAX
             * 
             * for (COUNTER; CONDITION; UPDATE)
             * {
             *      //code to run
             * }
             * 
             * Some books refer to COUNTER as INITIALIZER
             * //! Mnemonic device: ICU 
             * 
             * Counter - the starting point where you initailize a 
             * variable that is used to check the condition. The 
             * counter gets updated after each pass through the loop.
             *
             * Condition - A Boolean statement that tells the loop
             * when to stop. It is checked before each pass.
             * 
             * Update - the change to the counter after each 
             *          pass of the loop (increment, decrement, etc.)
             * 
             * Remember: a for loop is best used when you know exactly 
             *           how many times you want to run the code
             *           
             * For loops are common and useful in many algorithms 
             * and methods in the C# language
             */

			//! Note below that the COUNTER is declared and initialized within the for loop and that it is only accessible within the loop.
			for (int candyBar = 1; candyBar <= 7; candyBar++)//unary operator
			{
				Console.WriteLine("Yum! You have had " + candyBar);
			}//end for

			//start with 3 grapes and eat until you have had 15.
			//Eat 3 at a time.
			for (int grapes = 3; grapes <= 15; grapes += 3)
			{
				//could have also done the update as
				//cookie = cookie + 3
				Console.WriteLine("You ate three grapes and have "
					+ "now had " + grapes + "!");
			}//end for


			//count to 20, but skip 13
			for (int count = 1; count <= 20; count++)
			{
				if (count != 13)
				{
					Console.WriteLine(count);
				}
			}//end for

			//The continue keyword stops the current iteration of the loop 
			//and moves on to the next iteration. Let's do the same example 
			//above, but with continue:
			for (int count = 1; count <= 20; count++)
			{
				if (count == 13)
				{
					continue;
				}
				Console.WriteLine(count);
			}


			//From user input
			Console.Write("\nHow many cookies do you want? ");
			int userCookies = int.Parse(Console.ReadLine());

			for (int cookie = 1; cookie <= userCookies; cookie++)
			{
				Console.WriteLine("You ate a cookie! " + cookie);
			}//end for

			//Running Total Variable
			//Creating a variable in an outer scope allows you 
			//to use it and make changes to it from an inner scope

			//Start by creating your running total variable.
			//This can be a numeric type or a string that you
			//just tack info onto
			string listOfNames = "";//typically called an empty string

			Console.WriteLine("\n\nREGISTRATION\n");
			Console.Write("How many people would you like to " +
				"register for Comic Con? ");
			int totalReg = Convert.ToInt32(Console.ReadLine());

			for (int reg = 0; reg < totalReg; reg++)
			{
				Console.Write("Please enter a name: ");
				listOfNames += Console.ReadLine() + "\n";
			}//end for

			Console.WriteLine($"\nYou have registered:\n{listOfNames}");
			//Another example:


			//we can loop through an array with a for statement
			decimal[] prices = { 15.95m, 9.99m, 20, 10, 9.75m };

			for (int i = 0; i < prices.Length; i++)
			{
				Console.WriteLine("At the index of {0} is {1:c}",
					i, prices[i]);
			}//end for

			Console.WriteLine("The total is: {0:c}", prices.Sum());

		}//end Main()
	}//end class
}//end namespace
