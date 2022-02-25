using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Itunu
{

    class Assignment
    {
      static void Main(string[]args) 
        {
        	int i = 4;
        	double d = 4.0;
        	string s = "polyilaro";
        	
        	//Declare second integer, double, and string variable
        	
        	Console.Write("Enter second integer:");
        	int second_p = Convert.ToInt32(Console.ReadLine());
        	Console.Write("Enter second double:");
        	Double second_q = Convert.ToDouble(Console.ReadLine());
        	Console.Write("Enter second string:");
        	string second_value = Console.ReadLine();
        	
        	//print the sum of both integer variable on a new line
            Console.WriteLine(i + second_p);
           //print the sum of both double integer on a new Line
           Console.WriteLine(d + second_q);
           //Concatenate and print the string variable on a new line
           Console.WriteLine(s + second_value);
           Console.ReadLine ();
        }
    }
}