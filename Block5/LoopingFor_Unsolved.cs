using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block5
{
	class LoopingForUnsolved
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
			// Make a standard for loop
			// ==================== INSERT CODE BELOW ====================




			//start with 3 grapes and eat until you have had 15.
			//Eat 3 at a time.
			// ==================== INSERT CODE BELOW ====================




			//count to 20, but skip 13
			// ==================== INSERT CODE BELOW ====================




			//The continue keyword stops the current iteration of the loop 
			//and moves on to the next iteration. Let's do the same example 
			//above, but with continue:
			// ==================== INSERT CODE BELOW ====================




			//From user input ask the user how many cookies they want and make them each 1 cookie at a time
			// ==================== INSERT CODE BELOW ====================




			//Running Total Variable
			//Creating a variable in an outer scope allows you 
			//to use it and make changes to it from an inner scope

			//Start by creating your running total variable.
			//This can be a numeric type or a string that you
			//just tack info onto
			// ==================== INSERT CODE BELOW ====================




			//Another example:
			//we can loop through an array with a for statement
			// ==================== INSERT CODE BELOW ====================




		}//end Main()
	}//end class
}//end namespace
