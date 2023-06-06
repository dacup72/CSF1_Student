using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block4
{
	internal class BranchingIfUnsolved
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
			// Output a message to the console based on what day it is.
			// ==================== INSERT CODE BELOW ====================



			//Now a FULL IF TREE
			//Only 1 scope of an IF tree will run
			int monsterStrength = 100;
			int heroStrength;
			Console.WriteLine("In this cave you see bones and a white rabbit.");
			Console.Write("Enter your attack strength: ");
			heroStrength = Convert.ToInt32(Console.ReadLine());

			// If hero strength is greater than monster strength
			// Else if hero strength is equal to monster strength
			// Else if hero strength is greater than or equal to 75% of monster strength
			// Else if hero strength is greater than zero
			// Else if hero strength is greater than 20
			// Else make a default action
			// ==================== INSERT CODE BELOW ====================






			//Because a bool stores a true or false value, we can
			//use a bool to determine whether or not an IF
			//should run
			bool runMe = true;
			// ==================== INSERT CODE BELOW ====================



			//Capture user input to determine if the user should
			//have access to some functionality:
			// Use 2 seperate If blocks
			bool isAdmin = false;

			Console.Write("Enter your username: ");
			// ==================== INSERT CODE BELOW ====================




			//NESTED IF, you can NEST if trees inside of branches
			//of other trees

			Console.Write("Shall we play a game? ");
			string userWillPlay = Console.ReadLine().ToUpper();
			// Possible answers = "Y" , "YES" , "N" , "NO"
			// If the answer is of the yes category then ask the user if they want to play frogger, chess, or war
			// If the answer is of the no category then make a message responding to it
			// Be sure to account for situations where the user does not enter a valid string
			// ==================== INSERT CODE BELOW ====================





			//IF statements are GREAT with numeric ranges
			Console.Write("Enter the score on your physics exam: ");
			byte testScore = byte.Parse(Console.ReadLine());

			// If score is greater than or equal to 90, 80, 70, 60
			// Else default action
			// ==================== INSERT CODE BELOW ====================




			//The Ternary Operator is a quick inline if/else statement.
			//Syntax:
			//BooleanCondition ? codeIfTrue : codeIfFalse
			Console.Write("How many Daleks are there? ");
			int dalekCount = int.Parse(Console.ReadLine());
			// Use a ternary to make a console message be plural or singular based on user input
			// ==================== INSERT CODE BELOW ====================



		}//end Main()
	}//end Class
}//end Namespace
