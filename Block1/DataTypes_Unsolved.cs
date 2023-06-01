using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Block1
{
    internal class DataTypes_Unsolved
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Types: Bob Sure Is Loving");

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
			//===========================   INSERT CODE BELOW   ========================================
			byte byteNumber;


			//initialize (first assignment)
			//===========================   INSERT CODE BELOW   ========================================
			byteNumber = 12;


			//reassign
			//===========================   INSERT CODE BELOW   ========================================
			byteNumber = 128;



			//declare and initialize
			//===========================   INSERT CODE BELOW   ========================================
			double myDouble = 56.4;
			int myInt = 33;
			decimal myDecimal = 66.6m;
			float myFloat = 55f;


			//The name of the variable can be anything you want,however good variable names are typically descriptive of what you are storing or how the variable will be used.
			//EX: store shoes in a box called shoebox

			//use the C# lesser-used integer variants
			//===========================   INSERT CODE BELOW   ========================================
			ushort myUShort = 2;
			sbyte mySbyte = 8;


			//Let's Declare and initialize a ushort, uint and ulong
			//===========================   INSERT CODE BELOW   ========================================
			int myInt1, myInt2 = 7, myInt3;
			int myInt4; short myShort2;


			//int someInt = 23.7;
			//Int holds whole numbers. Therefore, we cannot put this value into an int type container.



			//*****Floating Point Types*****//
			//Floating point types support decimal values
			//===========================   INSERT CODE BELOW   ========================================
			//float anotherFloat = 56.7f;
			//double anotherDouble = 34.9;
			//decimal anotherDeciml = 77.2m;// Most accurate


			//double is the default floating point value
			//===========================   INSERT CODE BELOW   ========================================
			decimal anotherDeciml = 77.2m;// Most accurate
			
			
			
			


			//Decimal is the greatest accuracy... 128 bits, 29 digits
			//===========================   INSERT CODE BELOW   ========================================
			float anotherFloat = 56.7f;


			//float floatNbr = 29.345;
			//below works with f or F, case doesn't matter
			//because .Net has a shortcut for both
			//===========================   INSERT CODE BELOW   ========================================


			//Decimal only works with m or M (money!!)
			//===========================   INSERT CODE BELOW   ========================================


			//For double no suffix needed because .net sees a floating point
			//value as already being a double
			//===========================   INSERT CODE BELOW   ========================================
			double anotherDouble = 66.008;




			//****Boolean****//
			//Bool accepts only values of true or false --
			//no quotes... quotes would be for a string
			//===========================   INSERT CODE BELOW   ========================================
			bool isSomethingCorrect = true;
			Console.WriteLine("is the answer correct " + isSomethingCorrect);

			//reassigned!
			//===========================   INSERT CODE BELOW   ========================================
			isSomethingCorrect = false;
            Console.WriteLine("is the answer correct " + isSomethingCorrect);



            //**** Char ****//
            //The char datatype accepts a single character value
            //contained in single quotes
            //===========================   INSERT CODE BELOW   ========================================


            string someChar = "A";
            char someChar2 = 'a';
            char symbol = '3';


			//string accepts any number of characters in double quotes
			//===========================   INSERT CODE BELOW   ========================================
			string thisIsMyNewString = "my new string has a lot of characters";
			string firstName = "Dylan";
			string lastName = "Acup";



			//**** Concatenation ****//
			//With some creative concatenation we can do a little formatting
			//of our string outputs
			//===========================   INSERT CODE BELOW   ========================================
			string fullName = firstName + " " + lastName;



			//Let's use concatenation to write out James Bond's signature introduction.
			//===========================   INSERT CODE BELOW   ========================================
			Console.WriteLine("my first name is " + firstName + "   " + "But my full name is " + fullName);


		}//end Main()
	}//end class
}//end Namespace
