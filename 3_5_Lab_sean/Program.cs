using System;

namespace _3_5_Lab_sean
{
    class Program
    {
        static void Main(string[] args)
        {
            string blackListWord = "bomb";
            bool isSpam = false;
            string message = Console.ReadLine();
            if (message.Contains(blackListWord))
            {
                isSpam = true;
                Console.WriteLine("The message is spam");
            }
            else
            {
                isSpam = false;
                Console.WriteLine("The message is not spam.");
            }
        }
    }
}
