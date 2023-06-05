using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3
{
	internal class MadLibLab
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Mad Lib Lab");

			Console.WriteLine("Enter values to complete the mad lib.\n\n");
			Console.Write("Enter a boy's name: ");
			string boysName = Console.ReadLine();

			Console.Write("Enter a noun: ");
			string noun = Console.ReadLine();

			Console.Write("Enter an occupation: ");
			string occupation = Console.ReadLine();

			Console.WriteLine("Enter an adjective: ");
			string adjective = Console.ReadLine();

			string madLib = string.Format("{0} is a valuable member of the Ministry of Magic." +
				" Today {0} was in a rush to get to a meeting with the Minister of Magic" +
				" and he forgot his {1}. This is problematic because when you work as a " +
				"{2} you must have your {1} or you will have a really {3} day.", boysName,
				noun, occupation, adjective);

			Console.WriteLine(madLib);

		}//end Main()
	}//end Class
}//end Namespace
