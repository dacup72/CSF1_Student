using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Block2
{
	class CastingSolved
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Casting!");

			#region Casting Notes
			/*
             * Casting is copying the value from a variable of one
             * type to a variable of a different, but similar type.
             * 
             * IMPLICIT Casting: copies the contents from a smaller
             * container to a larger container (aka data type).
             * This always fits.
             */
			#endregion

			byte toothpasteBox = 1;
			short shoeBox = 200;
			int movingBox = 32261;
			long fridgeBox;//Just declared, not initialized.

			fridgeBox = toothpasteBox;//Implicit casting (byte to a long)
									  //Always works because the value can fit in the larger container
			Console.WriteLine("Fridge box has a value of: " + fridgeBox);

			long ovenBox = fridgeBox;//Not casting, just assigning the value
									 //of a variable from one container to another of the SAME data type.

			Console.WriteLine("The second fridge box has a value of: " + ovenBox);

			//toothpasteBox = fridgeBox;
			/* 
             * EXPLICIT Casting - going from a larger to a smaller
             * container. This requires extra work.
             * 
             * You have to explicitly state the data type you're 
             * casting to. This can create issues if the value won't fit.
             * 
             * Explicit = Explain
             * */

			toothpasteBox = (byte)shoeBox;
			//casting shoeBox value to a toothpasteBox explicitly
			Console.WriteLine("Toothpaste Box has a value of: " +
				toothpasteBox);

			Console.WriteLine("Shoe Box remains the same value: " +
			   shoeBox);

			/*
             * If you explicitly cast a LARGER value to a 
             * small container... you get a mess (truncation)
             * 
             * Above we set movingBox to be 32261. What happens if we
             * copy that value to a byte?
             * 
             */

			toothpasteBox = (byte)movingBox;
			//toothpasteBox is equal to the byte version of the movingBox
			Console.WriteLine("Toothpaste Box is now: " + toothpasteBox);
			Console.WriteLine("Moving Box is still: " + movingBox);

			//Cast the long into the int and display it:
			movingBox = (int)fridgeBox;//right to left thinking


			decimal dec1 = 4.3m;

			decimal dec2 = (decimal)4.3;

			//Both of the lines above are the same.
			//m or M is a shortcut for explicitly casting
			//a double to a decimal

			decimal deathStars = 1.75m;

			//An example where truncation might actually be useful:

			int completedDS = (int)deathStars;

			//!Instructor Note This is a great place to introduce CW --> tab --> tab
			Console.WriteLine("Out of " + deathStars +
				" Death Stars, only " + completedDS +
				" was completed.");



		} //end method
	}//end class
}//end namespace
