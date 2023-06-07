using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block4
{
	internal class BranchingSwitchSolved
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

			switch (userNumber)
			{
				case 1:
					Console.WriteLine("You typed 1");
					break;

				case 2:
				case 3:
				case 4:
				case 5:
				case 42:
					Console.WriteLine("You typed 2-5 or 42");
					//treats multiple cases like ||
					break;

				default:
					//optional, has no test, is like an else
					Console.WriteLine("You picked something else");
					break;
			}//end switch

			//IF YOU SEE THE ERROR CANNOT FALL OUT
			//you missed a break;

			//Note although we did ranges above, this should
			//illustrate that ranges do NOT work well with switches

			//switches are commonly used for menus!
			Console.WriteLine("\n\nPlease choose a program to run.\n" +
				"1) Numbers\n2) Drawing\n3) Water\n4) Change");
			string userOption = Console.ReadLine().ToUpper();

			switch (userOption)
			{
				case "1":
				case "NUMBERS":
				case "N":
					Console.WriteLine("1, 2, 3, 4, 5, 6, 7, ah ah ah");
					break;

				case "2":
				case "DRAWING":
				case "D":

					//code to run, could be hundreds of lines of code
					//!Alternatively, pull an ascii image from Chris.com here:
					Console.WriteLine(@"Lookie! I made a sword!

                        o=={:::::::::::::::::>

                    ");
					break;//break the fall

				case "3":
				case "WATER":
				case "W":
					Console.WriteLine("Water Lab!!");
					//you can copy and paste all of your code from 
					//INSIDE of the static void main for your water lab
					//to this spot!!
					break;

				case "4":
				case "CHANGE":
				case "C":
					Console.WriteLine("Change Lab!!");
					//add your change lab code here!
					break;

				default:
					Console.WriteLine("Input unrecognized. Please " +
						"restart the program and try again.");
					break;

			}//end switch
		}//end Main()
	}//end Class
}//end Namespace
