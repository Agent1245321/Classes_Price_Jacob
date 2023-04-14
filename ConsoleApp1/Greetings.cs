using System;

namespace ConsoleApp1
{
	//the greetings class
	public class Greetings
	{
		//Welcomes te user
		public void Welcome()
		{
			Console.WriteLine("Welcome to the Class Project!");
		}


		//Greets them with a hello
		public void Hello(string name)
		{
			Console.WriteLine($"Hello {name}, its good to see you here!");
		}
	}
}
