using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Практика_4___пробник_2__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string s = Console.ReadLine();
            s = s.Trim();
            s = s.Replace(" ", ""); 
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = s.Length - 1; j > 0; j--)
                {
                    if (s[i] == s[j])
                        Console.WriteLine("Введенная строка - палиндром");
                    else
                        Console.WriteLine("Введенная строка - не палиндром");
                    Console.ReadLine();
                }
            }
        }
    }
}