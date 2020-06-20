using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a length");
            string input = Console.ReadLine();
            int intput = Int32.Parse(input);
            var answer = new List<int>();
            var lastnumber = 0;
            var currentnumber = 1;
            var value = 0;
            answer.Add(0);
            for (int i = 0; i < intput; i++)
            {
                value = (lastnumber + currentnumber); 
                answer.Add(value);
                lastnumber = currentnumber;
                currentnumber = value;
            }
            for (int i = 0; i < intput; i++)
            {
                if (i != 0)
                {
                    Console.Write(", ");
                    Console.Write(answer[i]);
                }
                else
                {
                    Console.Write(answer[i]);
                }

            }

        }
    }
}
