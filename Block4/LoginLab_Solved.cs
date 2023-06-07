using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block4
{
	internal class LoginLabSolved
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Login Lab");

			string username = "thechosenone";

			Console.Write("Please enter your ministry assigned username: ");
			string userInput = Console.ReadLine().ToLower();

			if (userInput == username)
			{
				Console.WriteLine("\n\n....Ministry access granted.");
			}
			else
			{
				Console.WriteLine("Username incorrect. Ministry access denied.");
			}

			Console.WriteLine();

			Console.Write("Please enter one of this week's secret catch phrases: ");
			string userPhrase = Console.ReadLine().ToLower();

			switch (userPhrase)
			{
				case "gryffindors are the bravest":
					Console.WriteLine("The phrase is correct and the sentiment is accurate.");
					break;
				case "slytherins are the kindest people on the planet":
					Console.WriteLine("The phrase is correct but you're joking right?");
					break;
				case "hufflepuffs have the best dad jokes":
					Console.WriteLine("The phrase is correct but I have seen no evidence of this.");
					break;
				case "ravenclaws are geniuses":
					Console.WriteLine("The phrase is correct and I couldnt agree more.");
					break;
				default:
					Console.WriteLine("The phrase you entered is not correct. You must leave the Ministry now!");
					break;
			}


		}
	}
}
