//Adding // to the start of a line creates a single line comment that is ignored by the compiler 
/*
 * You can also create multi-line comments like this.
 * They are also ignored by the compiler.
 */

//Using statements in C# define resources from .NET that this file needs to be able to execute.
//In the current version of .NET, some using statements are implicit or automatically added by the compiler.
//We will add the manually so you can see what is going on behind the scenes. 
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
//As you need more resources from .NET you will add each resources using statement.

//A namespace refers to the project your code lives in. Here, it is Block1. Namespaces are traditionally defined using the PascalCase naming convention.
namespace Block1
{
    //in 

    //A class is a file that contains code that your app will use to run. They are traditionally defined using the PascalCase naming convention
    class Variable_Unsolved
    {
        //A method is like the verb of the C# language. It is where action is performed. Use SVM + Tab + Tab to generate the method we need for our console app.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
			//We save our changes with CTRL + S for this file or CTRL + SHIFT + S for all files. 
			//We can build (aka compile) our project with CTRL + SHIFT + B
			//We can launch (aka run) our project with CTRL + F5. (This actually does the save and build as well.)

			/*****Important Things to Know About C#*******
            * 
            * 
            * C# curly braces are used to define the scope of something. They say, all of the content inside of them relates to this one thing. Here all the code inside of the curly 
            * braces relates to the Main(). 
            * 
            * A semicolon is used like a period to show the end of a line of code
            * 
            * C# largely ignores whitespace, except when inside of string (i.e. "Hello, world!" above)
            * 
            * C# is case sensitive meaning that example and Example could refer to different things. 
            * 
            * C# is type-safe which means when something is created you define what type of thing it is and it stays that type forever.
            */

			//*******Variables******//

			//A variable is just a container to hold information. When a container is created, you must define what type of data it will hold (type-safety).
			//The data stored in a container can be changed. 
			//Variables are traditionally defined using the camelCase naming convention. 
			//Variable names can ....
			//   - only begin with alphabetic characters or underscores
			//   - cannot contain spaces
			//   - must contain at least 1 alpha or numeric character
			//   - cannot be a reserved keyword (i.e. class, static, void...all shown in dark blue)
			//   - be unique within their scope {}

			//When making a variable you go through three steps: Declaration, Initialization, and Assignment
			//1. Declaration: this is when the container is created. It is given a name and a data type. 
			//2. Initialization: this is when the container is given a value for the first time. 
			//3. Assignment: giving the container a new value, after the first time

			//***Creating Variables***//
			//declaration - data type then name (camelCase)
			//===========================   INSERT CODE BELOW   ========================================



			

			//string firstExample; This code didn't work because all variables in the same scope must be uniquely named. 

			//initialization 
			//once it is declared you refer to it by name only. DO NOT put the data type. C# would think you are trying to make a new container.
			//===========================   INSERT CODE BELOW   ========================================



            

			//assignment
			//===========================   INSERT CODE BELOW   ========================================



            

            //Usually variables are declared and initialized in the same line....
            //===========================   INSERT CODE BELOW   ========================================



            

            //lets see the information from the container called name that holds string data printed off to the console
            //===========================   INSERT CODE BELOW   ========================================




            //What you see in the console depends on the value the variable has at that certain point



            //*****Declaring Multiple Variables****//
            //You can make many variables at one time
            //Lets declare several containers that all hold the same type of data.
            //===========================   INSERT CODE BELOW   ========================================
            


            //the containers are created but they have no values. We need to initialize each variable before we can use it. It doesn't matter what order you do this in. 
            //===========================   INSERT CODE BELOW   ========================================




            //You can also declare and initialize many variables at the same time or do a mix of both
            //===========================   INSERT CODE BELOW   ========================================



            //The variables firstName and lastName have a value so they can be used immediately.
            //===========================   INSERT CODE BELOW   ========================================




            //When declaring multiple variables, you cannot mix data types 
            //int mlsTeams = 19, mlsChampions = "SportingKC"; this will not work
            //int mlsTeams = 19, string mlsChampions = "SportingKC"; this will not work
            //===========================   INSERT CODE BELOW   ========================================



            //*****Constants****//
            //You can declare variables whose value never changes. These are called constants and they must be declared and initialized at the same time.
            //===========================   INSERT CODE BELOW   ========================================



            //constants can be used like normal variables
            //===========================   INSERT CODE BELOW   ========================================



            //****Literal Values****//
            //difference between variables and literal values
            //===========================   INSERT CODE BELOW   ========================================






            //***Difference Between String and Int***//
            //Strings store an unlimited number of text characters (alpha, numeric, and symbols)
            //Ints store only numeric values 
            //These differences in the type of information stored causes them to behave differently as well

            //Add two ints together
            //===========================   INSERT CODE BELOW   ========================================



            //***Generating Output***//
            //You can use concatenation to print out a combination of text a numeric values
            //===========================   INSERT CODE BELOW   ========================================





        } //end method
    }//end class
}//end namespace
