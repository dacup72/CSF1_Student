using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block4
{
	internal class BranchingIfSolved
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Branching with If");

			/*
             * If allows you to test for a condition. If that
             * condition is true it runs the code inside of the scope.
             * Otherwise, the scope is skipped.
             * 
             * Optionally, you can add one or more else ifs that will
             * run if the previous conditions were not met and their
             * condition is true.
             * 
             * Optionally, you can also include 1 final ELSE with NO
             * condition, it will always run if nothing else above
             * did, and it MUST always be the last statement of
             * an IF tree.
             */

			Console.WriteLine("What day is it? Monday, Tuesday, etc");
			string userDay = Console.ReadLine().ToLower();

			if (userDay == "thursday")
			{
				//The code here in this scope will run ONLY if the
				//above condition is true
				Console.WriteLine("Only one more day to the weekend!");
			}//end if

			Console.WriteLine("\nMoving Along....\n");

			//Now a FULL IF TREE
			//Only 1 scope of an IF tree will run
			int monsterStrength = 100;
			int heroStrength;
			Console.WriteLine("In this cave you see bones and a white rabbit.");
			Console.Write("Enter your attack strength: ");
			heroStrength = Convert.ToInt32(Console.ReadLine());

			if (heroStrength > monsterStrength)
			{
				Console.WriteLine("You use the Holy Hand Grenade of Antioch" +
					" and blow the rabbit to tiny bits.");
			}//end if
			else if (heroStrength == monsterStrength)
			{
				//player entered the same number as the rabbit's
				//strength
				Console.WriteLine("Alright, then. We'll call it a draw.");
			}//end else if
			else if (heroStrength >= monsterStrength * .75)
			{
				//if the user entered a number greater than
				//75% of the rabbit's strength, this will run.
				//if the rabbit's strength is 100, this checks for
				//76-99
				Console.WriteLine("You die a valiant death, but " +
					"put up a great fight.");
			}//end else if
			else if (heroStrength > 0)
			{
				//1-74 is what the user entered, so this runs
				Console.WriteLine("You join the pile of bones!");
			}//end else if
			else if (heroStrength > 20)
			{
				//This will NEVER run. In order for this condition
				//to be true, one of the conditions above was already
				//true and the if tree was exited.
				//This is a logic error.
				Console.WriteLine("This will NEVER run!!!");
			}//end else if
			else
			{
				//NO CONDITION FOR AN ELSE STATEMENT
				//must be the LAST statement of an IF tree
				//this will run if the user entered 0 or a negative
				//number
				Console.WriteLine("Dude.... you're already dead...");
			}//end else

			//The condition just needs to be or resolve to
			//a true or false value

			//Because a bool stores a true or false value, we can
			//use a bool to determine whether or not an IF
			//should run
			bool runMe = true;

			if (runMe)
			{
				Console.WriteLine("\nProgram running...\n");
			}//end if

			//Capture user input to determine if the user should
			//have access to some functionality:
			bool isAdmin = false;

			Console.Write("Enter your username: ");
			string username = Console.ReadLine().ToUpper();

			if (username == "CHRIS" || username == "ADMIN")
			{
				isAdmin = true;
			}//end if

			if (isAdmin)
			{
				Console.WriteLine("You're an admin!");
			}//end if

			//NESTED IF, you can NEST if trees inside of branches
			//of other trees

			Console.Write("Shall we play a game? ");
			string userProgram = Console.ReadLine().ToUpper();

			if (userProgram == "Y" || userProgram == "YES")
			{
				//Console.WriteLine("Program running");
				//! come back and give them options for games
				Console.WriteLine("Type chess, frogger or war");
				string userGame = Console.ReadLine().ToLower();

				if (userGame == "chess")
				{
					Console.WriteLine("I calculate that you would lose. Checkmate!");
				}//end if chess
				else if (userGame == "frogger")
				{
					Console.WriteLine("You're too slow... SPLAT!");
				}//end else if frogger
				else if (userGame == "war")
				{
					Console.WriteLine("Global thermonuclear war executed!");
				}//end else if
				else
				{
					Console.WriteLine("Response not understood.");
				}
			}//end if they typed yes or y

			else if (userProgram == "N" || userProgram == "NO")
			{
				Console.WriteLine("We didn't want you to play our"
					+ " games anyway....");
			}//end else if n or no

			else
			{
				Console.WriteLine("Response not understood, " +
					"please restart.");
			}//end else


			//IF statements are GREAT with numeric ranges
			Console.Write("Enter the score on your physics exam: ");
			byte testScore = byte.Parse(Console.ReadLine());

			//! if --> tab --> tab

			if (testScore >= 90)
			{
				Console.WriteLine("Great job! You got an A!!");
			}//end if A
			else if (testScore >= 80)
			{
				Console.WriteLine("Fair job.... B");
			}//end if B
			 //MINI-LAB!
			 //70 and over is C
			 //60 and over is D
			 //everything below 60 is F
			else if (testScore >= 70)
			{
				Console.WriteLine("Adequate.. C");
			}//end if C
			else if (testScore >= 60)
			{
				Console.WriteLine("Poor.... D");
			}//end if D
			else
			{
				Console.WriteLine("Dude... Did you even try?");
			}//end if F

			//The Ternary Operator is a quick inline if/else statement.
			//Syntax:
			//BooleanCondition ? codeIfTrue : codeIfFalse
			Console.Write("How many Daleks are there? ");
			int dalekCount = int.Parse(Console.ReadLine());
			Console.WriteLine("Oh, no! {0} Dalek{1}!",
				dalekCount,
				dalekCount == 1 ? "" : "s");
		}//end Main()
	}//end Class
}//end Namespace
