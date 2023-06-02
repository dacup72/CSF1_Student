using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block2
{
	internal class OperatorsLabSolved
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Operators Lab");

			//1
			byte square = 75;

			Console.WriteLine("The permieter of the square is " + (4 * square));

			//2
			byte cuboidHeight = 45;
			byte cuboidDepth = 20;
			byte cuboidLength = 65;

			Console.WriteLine("The volume of a cuboid that is 45in high, 20in deep, and 65in long is " + (cuboidDepth * cuboidHeight * cuboidLength));

			//3
			int vanCapacity = 9;
			int passengers = 146;
			Console.WriteLine("There were " + (passengers / vanCapacity) + " transport vans. There are still " + (passengers % vanCapacity) + " passengers that need to be transported.");

			//4
			byte girlScoutCookies = 5;
			Console.WriteLine("The girl scout started out with " + girlScoutCookies);
			girlScoutCookies -= 2;
			Console.WriteLine("The girl scout is taking " + girlScoutCookies + " to the next house.");

			//5
			int aliens = 5;

			Console.WriteLine(aliens-- + " aliens came to earth but one went home. There were then 4 aliens. Two more aliens came to earth which means there were a total of "
				+ (aliens += 2) +
				". Another alien came to earth making the total " + aliens++ + ".  Most of the aliens formed pairs and traveled to other planets but there was "
				+ (aliens %= 2) + " alient left alone on earth.");

		}//end Main()
	}//end Class
}//end Namespace
