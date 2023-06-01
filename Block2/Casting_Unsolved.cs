using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Block2
{
    class CastingUnsolved
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Casting!");

            
            /*
             * Casting is copying the value from a variable of one
             * type to a variable of a different, but similar type.
             * 
             * IMPLICIT Casting: copies the contents from a smaller
             * container to a larger container (aka data type).
             * This always fits.
             */


            byte toothpasteBox = 1;
            short shoeBox = 200;
            int movingBox = 32261;
            long fridgeBox;//Just declared, not initialized.


            //Implicit casting (byte to a long)
            //===========================   INSERT CODE BELOW   ========================================
            fridgeBox = toothpasteBox;
            Console.WriteLine("My fridge " + fridgeBox);




            //Not casting, just assigning the value
            //of a variable from one container to another of the SAME data type.
            //===========================   INSERT CODE BELOW   ========================================
            long oven = fridgeBox;
			Console.WriteLine("My oven " + oven);


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

            //casting shoeBox value to a toothpasteBox explicitly
            //===========================   INSERT CODE BELOW   ========================================
            toothpasteBox = (byte)shoeBox;
            Console.WriteLine(toothpasteBox);




			/*
             * If you explicitly cast a LARGER value to a 
             * small container... you get a mess (truncation)
             * 
             * Above we set movingBox to be 32261. What happens if we
             * copy that value to a byte?
             * 
             */

			//toothpasteBox is equal to the byte version of the movingBox
			//===========================   INSERT CODE BELOW   ========================================
			toothpasteBox = (byte)movingBox;
			Console.WriteLine(toothpasteBox);


            //Cast the long into the int and display it:
            //===========================   INSERT CODE BELOW   ========================================
            long myLong = 55;
            int myInt = 99;

            myInt = (int)myLong;
            Console.WriteLine(myInt);



            //m or M is a shortcut for explicitly casting
            //a double to a decimal
            //===========================   INSERT CODE BELOW   ========================================
            
            double myDouble = 66.6;
            decimal myDecimal = (decimal)myDouble;




			//An example where truncation might actually be useful:
			//===========================   INSERT CODE BELOW   ========================================
			decimal deathStars = 1.75m;
			int completedDS = (int)deathStars;
			Console.WriteLine("Out of " + deathStars +
				" Death Stars, only " + completedDS +
				" was completed.");
           
            Console.WriteLine(deathStars.ToString() + " hello");

        } //end method
    }//end class
}//end namespace
