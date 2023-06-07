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
			//    Console.Write("Enter a score ({0}): ", count + 1);
			//    scores[count] = int.Parse(Console.ReadLine());
			//    Console.Clear();
			//}

			//Array.Sort(scores);

			//int total = scores.Sum();
			//double average = scores.Average();

			//Console.WriteLine("The lowest is {0}, the highest is {1} and the " +
			//"average is {2}.",
			//scores[0],
			//scores[scores.Length - 1],
			//average);
		}//end Main()
	}//end class
}//end Namespace
