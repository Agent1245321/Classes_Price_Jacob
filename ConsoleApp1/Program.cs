using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //makes a new instance of the class Greetings
            Greetings greetings = new Greetings();
            
            //callse the class methods
            greetings.Welcome();
            greetings.Hello("Huston");
        }
    }
}
