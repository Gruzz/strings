using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            bool oneMoreTime = true;
            while (oneMoreTime)
            {
                Console.WriteLine("Enter string");
                string inStr = Console.ReadLine();
                string newStr = ToCase(inStr);
                Console.WriteLine("New string: " + newStr);
                oneMoreTime = next();
            }                   
        }
        public static string ToCase(string str)
        {
            int upCase = 0;
            int lowCase = 0;
            if (str != null)
            {
                for (int index = 0; index < str.Length; index++)
                {
                    if ((str[index] >= 'A') && (str[index] <= 'Z'))
                    {
                        upCase++;
                    }
                    else
                    {
                        if ((str[index] >= 'a') && (str[index] <= 'z'))
                        {
                            lowCase++;
                        }
                    }
                }
                if (upCase > lowCase)
                {
                    str = str.ToUpper();
                }
                else
                {
                    if (upCase < lowCase)
                    {
                        str = str.ToLower();
                    }
                    else
                    {
                        if ((upCase == 0) && (lowCase == 0))
                        {
                            Console.WriteLine("Empty String");
                        }
                        else
                        {
                            Console.WriteLine("the number of big letters is equal to the number of small ones");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("String must not be null");
            }
            return str;
        }
        public static bool next()
        {
            bool proverka = true;
            while (proverka)
            {
                Console.WriteLine("Want to enter another string? (y/n)");
                string choise = Console.ReadLine();
                if ((choise == "y") || (choise == "Y"))
                    return true;
                else
                    if ((choise == "n") || (choise == "N"))
                        return false;
            }            
            return true;
        }
    }
}
