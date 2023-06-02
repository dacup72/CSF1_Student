using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block2
{
	internal class CastingLabSolved
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Casting Lab");

			byte puddle = 100;
			short pond = 29456;
			int lake = 100000; //one hundred thousand
			long ocean = 5;

			//1. cast the value of lake into ocean and display it
			//2. cast the value of pond into puddle and display it
			//3. cast the value of pond into ocean and display it
			//4. cast the value of ocean into lake and display it
			//5. cast the value of puddle into ocean and display it

			//for each casting, include a comment categorizing it as:
			//implicit casting
			//explicit casting
			//explicit casting with truncation

			//1. lake into ocean
			ocean = lake;//implicit
			Console.WriteLine("Ocean is now " + ocean);

			//2. pond into puddle 
			puddle = (byte)pond;//explicit casting with truncation
			Console.WriteLine("Puddle is now " + puddle);

			//3. pond into ocean
			ocean = pond;//implicit
			Console.WriteLine("Ocean is now " + ocean);

			//4. ocean into lake
			lake = (int)ocean;//explicit casting
			Console.WriteLine("Lake is now " + lake);

			//5. puddle into ocean
			ocean = puddle; //implicit
			Console.WriteLine("Ocean is now " + ocean);
		}
	}
}
