using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block4
{
	internal class FruitsLabSolved
	{
		static void Main(string[] args)
		{
			string[] fruits = { "Banana", "Grape", "Strawberry", "Raspberry", "Dragon Fruit" };

			fruits[0] = fruits[0].Substring(0, fruits[0].IndexOf("a"));
			fruits[1] = fruits[1].Substring(0, fruits[1].IndexOf("a"));
			fruits[2] = fruits[2].Substring(0, fruits[2].IndexOf("a"));
			fruits[3] = fruits[3].Substring(0, fruits[3].IndexOf("a"));
			fruits[4] = fruits[4].Substring(0, fruits[4].IndexOf("a"));

			Console.WriteLine(fruits[0]);
			Console.WriteLine(fruits[1]);
			Console.WriteLine(fruits[2]);
			Console.WriteLine(fruits[3]);
			Console.WriteLine(fruits[4]);
		}
	}
}
