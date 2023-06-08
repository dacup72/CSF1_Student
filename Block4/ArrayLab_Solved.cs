using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block4
{
	internal class ArrayLabSolved
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Arrays Lab!");

			/*
             * REQUIREMENTS:
             * 1) Ask the user for 5 scores (1 at a time)
             * 2) Display the high, low and average score
             *  
             * The scores should be ones from a test, like 0-100
             */

			Console.WriteLine("Enter 5 scores to get the min, max and average.");

			int[] scores = new int[5];

			Console.Write("Enter your first score: ");
			scores[0] = int.Parse(Console.ReadLine());
			Console.Write("Enter your second score: ");
			scores[1] = int.Parse(Console.ReadLine());
			Console.Write("Enter your third score: ");
			scores[2] = int.Parse(Console.ReadLine());
			Console.Write("Enter your fourth score: ");
			scores[3] = int.Parse(Console.ReadLine());
			Console.Write("Enter your fifth score: ");
			scores[4] = int.Parse(Console.ReadLine());
			Array.Sort(scores);

			int total = scores.Sum();
			double average = scores.Average();

			Console.WriteLine("The lowest is {0}, the highest is {1} and the " +
			"average is {2}.",
			scores[0],
			scores[scores.Length - 1],
			average);









			//!Below solution can be shown on Friday with the For loop:
			//Console.Write("Enter 5 scores to get the min, max and average.");

			//int[] scores = new int[5];

			//for (int count = 0; count < scores.Length; count++)
			//{
			//	Console.Write("Enter a score ({0}): ", count + 1);
			//	scores[count] = int.Parse(Console.ReadLine());
			//	Console.Clear();
			//}

			//Array.Sort(scores);

			//int total = scores.Sum();
			//double average = scores.Average();

			//Console.WriteLine("The lowest is {0}, the highest is {1} and the " +
			//"average is {2}.",
			//scores[0],
			//scores[scores.Length - 1],
			//average);









			// Instructr Dylan Example

			//decimal[] scores = new decimal[5];
			//Console.WriteLine("Please enter your scores between 0 - 100");

			//for (int i = 0; i < scores.Length; i++)
			//{
			//	bool invalidInput = true;

			//	while (invalidInput)
			//	{
			//		Console.Write($"Please enter score number {i + 1}:  ");

			//		if (decimal.TryParse(Console.ReadLine(), out decimal output))
			//		{
			//			if (output >= 0 && output <= 100)
			//			{
			//				scores[i] = output;
			//				invalidInput = false;
			//			}
			//		}

			//		if (invalidInput)
			//			Console.WriteLine("Invalid score, please try again.");
			//	}
			//}

			//Array.Sort(scores);

			//Console.WriteLine(
			//	$"The Sum of all scores is {scores.Sum()}\n" +
			//	$"The Average of all scores is {scores.Average()}\n" +
			//	$"The lowest score is {scores[0]}\n" +
			//	$"The highest score is {scores[scores.Length - 1]}"
			//);



		}//end Main()
	}//end class
}//end Namespace
