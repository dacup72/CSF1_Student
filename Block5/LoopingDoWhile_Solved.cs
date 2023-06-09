using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block5
{
	internal class LoopingDoWhileSolved
	{
		static void Main(string[] args)
		{
			Console.WriteLine("The DO While Loop");
			Console.Title = "Looping with Do While";

			/* Do While Loop - best for when you want to run code
             * an indeterminable number of times BUT
             * at least once!!!
             * (1 to ???)
             * 
             * COUNTER
             * 
             * do
             * {
             *      //code to run
             *      UPDATE
             *      
             * } while (CONDITION);
             */

			int cookie = 1;//COUNTER

			do
			{
				Console.WriteLine("Yum!! You have had " + cookie);
				cookie++;//UPDATE
			} while (cookie <= 5);//CONDITION.. don't forget the ;

			//A bad do while below:
			//A do while will ALWAYS run at least one time
			Console.WriteLine("\nDo you want to run this program?");
			string runProgram = Console.ReadLine().ToUpper();

			do
			{
				Console.WriteLine("Success!! Program is running!\n");

				//could be hundreds of lines of code

				Console.WriteLine("Keep going?");
				runProgram = Console.ReadLine().ToUpper();

			} while (runProgram == "Y" || runProgram == "YES");
			//CONDITION.. don't forget the ;

			//The ABOVE program is a logic error! A do while will
			//always run once!! The above example should have been
			//written as a while.

			//Real World Example
			bool repeat = true;//They want to use our program!!
							   //generally, you write a while or do while to run forever
							   //and just deal with when they want to stop.
							   //The above bool is the counter!!

			do
			{
				//do while ALWAYS runs once! Best for menus!!!
				Console.WriteLine("-= Wekk Ant Eeru Phone Company =-");
				Console.WriteLine("B) Bill\nP) Payment\nX) Exit");
				string userChoice = Console.ReadLine().ToUpper();

				//clear the console after input
				Console.Clear();

				switch (userChoice)
				{
					case "B":
					case "BILL":
						Console.WriteLine("Your balance is $500.00\n\n");
						break;

					case "P":
					case "PAYMENT":
						Console.WriteLine("Your payment is pending...\n\n");
						break;

					case "X":
					case "E":
					case "EXIT":
						Console.WriteLine("Thank you for calling.");
						//stop the loop....
						repeat = false;//UPDATE
						break;

					default:
						Console.WriteLine("That was not a valid option.\n" +
							"A $5 invalid option fee has been applied to your bill.");
						break;
				}//end switch
			} while (repeat);//CONDITION
		}//end Main()
	}//end Class
}//end Namespace
