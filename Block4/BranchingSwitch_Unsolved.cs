using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block4
{
	internal class BranchingSwitchUnsolved
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Branching: Switch Statements");

			/*
             * Switches are the other form of branching.
             * Not as flexible as IF (don't handle ranges well)
             * But GREAT at exact matching.
             * 
             * SYNTAX:
             * 
             * switch (valueToCheck)
             * {
             *      case TEST:
             *          //code
             *          break;
             *          
             *      default:
             *          //code
             *          break;
             * }
             */
			Console.Write("Enter a number: ");
			short userNumber = short.Parse(Console.ReadLine());
			// Use a switch statement to do the following:
			// Output message if the users enters 1
			// Output message if the user enter a range of 2 - 5 or 42
			// Output a default message
			// ==================== INSERT CODE BELOW ====================







			//IF YOU SEE THE ERROR CANNOT FALL OUT
			//you missed a break;

			//Note although we did ranges above, this should
			//illustrate that ranges do NOT work well with switches

			//switches are commonly used for menus!
			Console.WriteLine("\n\nPlease choose a program to run.\n" +
				"1) Numbers\n2) Drawing\n3) Water\n4) Change");
			string userOption = Console.ReadLine().ToUpper();
			// Use a switch to demonstrate the following:
			// For user input of "1", "NUMBERS", or "N" ouput a message
			// For user input of "2", "DRAWING", or "D" output a message
			// For user input of "3", "WATER", or "W" run the Water Lab
			// For user input of "4", "CHANGE", or "C" run the Change Lab
			// Supply a default case for unrecognized inputs
			// ==================== INSERT CODE BELOW ====================







		}//end switch
	}//end Main()
}//end Class
}//end Namespace
