using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace Pi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            int intput = Int32.Parse(input) + 1;
            int precision = 2 * intput;

            var Answerp = new List<int>();
            var Answerm = new List<int>();
            var TAnswer = new List<int>();
            TAnswer.Add(3);
            for (int i = 0; i < precision; i++)
            {
                TAnswer.Add(0); 
            }
            
            int denominator = 0;
            for (int j = 1; j <= intput; j++)
            {
                denominator = (j * 2) * (j * 2 + 1) * (j * 2 + 2);
                var fraction = Solve(denominator, precision);

                if (j % 2 == 1)
                    TAnswer = AddTo(TAnswer, fraction, precision);
                else
                    TAnswer = SubtractFrom(TAnswer, fraction, precision);
            }
            for (int i = 0; i <= precision; i++)
            {
                if(i == 1)
                {
                    Console.Write(".");
                }
                Console.Write(TAnswer[i]);
                    
            }

               
        } 
        static List<int> Solve(int d,int p)
        {
            int remainder = 0;
            int num2 = 4;
            int num1 = d;
            var list = new List<int>();

            for (int i = 0; i <= p; i++)
            {
                if (num1 > num2)
                {
                    list.Add(0);
                    num2 = num2 * 10;
                }
                else
                {
                    list.Add(num2 / num1);
                    remainder = num2 - ((num2 / num1) * num1);
                    num2 = remainder * 10;
                }
            }
            return list;
        }
        static List<int> AddTo(List<int> A, List<int> B, int p)
        {
            int carry = 0;
            for (int i = 0; i <= p; i++)
            {
                if ((A[p-i] + B[p - i] + carry) >= 10)
                {
                    A[p - i] = (B[p - i] + carry + A[p - i] -10);
                    carry = 1;
                }
                else
                {
                    A[p - i] = (A[p - i] + (B[p - i] + carry));
                    carry = 0;
                }
            }
            return A;
        }
        static List<int> SubtractFrom(List<int> A, List<int> B, int p)
        {
            int carry = 0;
            for (int i = 0; i <= p; i++)
            {

                if (B[p - i] + carry > (A[p - i]))
                {
                    A[p - i] = 10 + A[p - i] - (B[p - i] + carry);
                    carry = 1;
                }
                else
                {
                    A[p - i] = (A[p-i] -(B[p - i] + carry));
                    carry = 0;
                }
            }
            return A;
        }
    }
}
