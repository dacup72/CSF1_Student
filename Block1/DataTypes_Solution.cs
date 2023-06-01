using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block1
{
    internal class DataTypes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Types: Bob Sure Is Loving");

            /*
             * ***Instructor Notes****
             * Try to run - FAIL! Show how to set startup project
             * 
             * Copy in the blank version of the data type notes below. Have students help you complete it.
            */


            //****Integar Types****//
            //Template
            /*
                           Data Type             Bits           Value Range          Lesser Used Variant          Value Range

            Bob            X                     X              X - X                X                            X - X

            Sure           X                     X              X - X                X                            X - X

            Is             X                     X              X - X                X                            X - X

            Loving         X                     X              X - X                X                            X - X
             */

            //Completed
            /*
                          Data Type             Bits           Value Range          Lesser Used Variant          Value Range

            Bob            byte                  8              0 - 255             sbyte                         -128 - 127

            Sure           short                 16             -32k - 32k          ushort                        0 - 65k

            Is             int                   32             -2bil - 2bil        uint                          0 - 4bil

            Loving         long                  64             -9quint - 9quint    ulong                         0 - 18quint
             */

            //declare
            byte byteNbr;

            //initialize (first assignment)
            byteNbr = 0;

            //reassign
            byteNbr = 255;

            //byteNbr = 1000;
            //above was too big for a byte

            //declare and initialize
            short shortNbr = -1234;
            int intNbr = 12392823;
            long longNbr = 23499903389034;

            //The name of the variable can be anything you want,however good variable names are typically descriptive of what you are storing or how the variable will be used.
            //EX: store shoes in a box called shoebox

            //use the C# lesser-used integer variants
            sbyte sbyteNbr = -7;

            //Let's Declare and initialize a ushort, uint and ulong
            ushort ushortNbr = 45;
            uint uintNbr = 654;
            ulong ulongNbr = 4567894; 

            //int someInt = 23.7;
            //Int holds whole numbers. Therefore, we cannot put this value into an int type container.



            //*****Floating Point Types*****//
            //Floating point types support decimal values
            float smallFraction = 12;//32 bits, 45 digits
            double smallFraction2 = 12.9;//64 bits, 324 digits
            //double is the default floating point value
            decimal smallFraction3 = 23;//decimal supports
            //the greatest accuracy... 128 bits, 29 digits

            //float floatNbr = 29.345;
            float anotherFloat = 34905730983908903.30495390f;
            //above works with f or F, case doesn't matter
            //because .Net has a shortcut for both

            decimal decimalNbr = 2908350928.209385092m;
            //only works with m or M (money!!)

            double doubleNbr = 290348509238608290.2309458029860982;
            //no suffix needed because .net sees a floating point
            //value as already being a double

            Console.WriteLine("Calculation Result: " +
                (anotherFloat / 2f));




            //****Boolean****//
            //Bool accepts only values of true or false --
            //no quotes... quotes would be for a string

            bool isTheDoctor = false;

            Console.WriteLine("Are you the Doctor? " + isTheDoctor);

            isTheDoctor = true;
            //reassigned!

            Console.WriteLine("Are you the Doctor? " + isTheDoctor);




            //**** Char ****//
            //The char datatype accepts a single character value
            //contained in single quotes
            char letter = 'A';
            //char someChar = "A";
            //char someChar2 = 'abc';
            char symbol = '%';

            Console.WriteLine("symbol is: " + symbol +
                " and letter is: " + letter);

            //string accepts any number of characters in double quotes
            string firstName = "James";
            Console.WriteLine(firstName);

            string lastName = "Bond";
            Console.WriteLine(lastName);




            //**** Concatenation ****//
            //With some creative concatenation we can do a little formatting
            //of our string outputs
            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine(firstName + ' ' + lastName);

            //Let's use concatenation to write out James Bond's signature introduction.

            Console.WriteLine(lastName + ". " + firstName +
                " " + lastName + '.');

        }//end Main()
    }//end class
}//end Namespace
