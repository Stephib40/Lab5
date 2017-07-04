using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
	class Program
	{
		static void Main()
		{
			do
			{
				Console.WriteLine("Welcome to Grand Circus Casino!");
				Console.WriteLine("How many sides to your dice?");
				int d = int.Parse(Console.ReadLine());

				Random rng = new Random();
			
				Console.WriteLine("Roll 1:");
				Console.WriteLine(rng.Next(1, d++));
				Console.WriteLine("Roll 2:");
				Console.WriteLine(rng.Next(1, d++));

			} while (Continue() == true);

		}

		public static Boolean Continue()
		{
			Boolean run;
			Console.WriteLine("Roll your dice again: y/n?");
			string answer = Console.ReadLine();

			if ((answer == "Y") || (answer == "y"))
			{
				run = true;
			}
			else if ((answer == "N") || (answer == "n"))
			{
				run = false;
				Console.WriteLine("Later.");
			}
			else
			{
				Console.WriteLine("Yadda Yadda");
				run = Continue();
			}
			return run;

		}
	}
}

		

