using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Практика
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = 0;
            Console.WriteLine("Введите строку:");
            string s = Console.ReadLine();
             
            s = s.Trim();
            s = s.Replace(" ", "");
        
            int i=0;
            int j = s.Length-1;
            do
            {
                if (s[i] == s[j])
                {
                    i++;
                    j--;
                    d++;
                }
                else
                {
                    Console.WriteLine("Введенная строка - не палиндром");
                    Console.ReadLine();
                }
            }
            while ( i < s.Length);
            if (d == s.Length )
                Console.WriteLine("Введенная строка - палиндром");
            else
                Console.WriteLine("Введенная строка - не палиндром");
            
        
            Console.ReadLine();

        }

    }
}
