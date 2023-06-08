using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block5
{
	internal class LoopingWhileSolved
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Looping While!");
			Console.Title = "-====== LOOPING WITH WHILE =====-";

			/*While loop - best for when you want to run code
             * an indeterminable number of times
             * (0 to ???)
             * 
             * COUNTER
             * 
             * while (CONDITION)
             * {
             *      //code to run
             *      UPDATE
             * }
             */

			int cookie = 1;//COUNTER

			while (cookie <= 5)//CONDITION.. NO SEMICOLON
			{
				//code to run
				Console.WriteLine("Yum! You have eaten " + cookie);

				cookie++;//UPDATE
			}//end while

			//because you can set the update conditionally
			//it is easy to forget it... or to accidently
			//create an infinite loop by using a bad condition

			//long number = 1;//COUNTER

			//while (number > 0)//CONDITION
			//{
			//    Console.WriteLine(number);
			//    number++;//UPDATE
			//}//end while

			//Virtually every time you have an infinite loop
			//you wrote the condition wrong.

			//Write a while loop that starts with 10 bags of groceries
			//and counts down as they are unloaded until there are none
			//remaining.
			int groceryBags = 10;

			while (groceryBags > 0)
			{
				Console.WriteLine("You have {0} bags of groceries left."
					+ " You are now unloading one!",
					groceryBags);
				groceryBags--;
			}//end while

			//It is most common to use a while loop with a bool
			//for a counter as this allows us to conditionally
			//change the bool for when we want to exit the loop

			bool moreBags = true;//COUNTER

			while (moreBags)//CONDITION just needs to be true
			{
				Console.WriteLine("\nYou have unloaded some groceries.");

				//ask the user if they have more bags! 
				//If not, we are done!
				Console.Write("Do you have more bags? Y/N: ");
				//ConsoleKey...
				ConsoleKey userAnswer = Console.ReadKey(true).Key;

				if (userAnswer == ConsoleKey.N)
				{
					moreBags = false;//UPDATE
				}//end if

			}//end while

			//PROGRAMMER REAL WORLD EXAMPLE
			//for Loops are great for a specific number of times to loop
			//They are ideal when you know the COUNT

			//While loops are great for an indeterminable number of times
			//They are ideal when you know the CONDITION

			Console.Write("Would you like to play a game? Y/N: ");
			ConsoleKey runProgram = Console.ReadKey(true).Key; //Counter

			while (runProgram == ConsoleKey.Y)
			{
				Console.WriteLine("\nYou win!");

				Console.Write("Play again? Y/N: ");
				runProgram = Console.ReadKey(true).Key;
			}//end while





			//// Instructor Dylan Example
			// Console.WriteLine("Do you want to play a game?  EX: \"y\" or \"yes\"");
			// string userChoice = Console.ReadLine().ToLower();

			// //bool playGame = userChoice == "y" || userChoice == "yes" ? true : false;
			// bool playGame = userChoice == "y" || userChoice == "yes";

			// while(playGame)
			// {
			//     Console.WriteLine("Which game do you want to play?\n1) Frogger\n2) Chess\n3) War");
			// 	string gameChoice = Console.ReadLine().ToUpper();

			// 	if(gameChoice == "FROGGER")
			// 	{
			//         Console.WriteLine("You played frogger!!!");
			//     }
			// 	else if (gameChoice == "CHESS")
			// 	{
			//         Console.WriteLine("You played chess!!!");
			//     }
			// 	else if(gameChoice == "WAR")
			// 	{
			//         Console.WriteLine("You played War!!!");
			//     }
			// 	else
			// 	{
			//         Console.WriteLine("That is not a valid game");
			//     }

			//     Console.WriteLine("Do you want to play again?  EX: \"y\" or \"yes\"");
			// 	string userChoice2 = Console.ReadLine().ToLower();
			// 	playGame = userChoice2 == "y" || userChoice2 == "yes";
			// }

			// Console.WriteLine("Game Over!");

		}//end Main()
	}//end Class
}//end Namespace
