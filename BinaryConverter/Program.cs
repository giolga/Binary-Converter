using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter
{
    internal class Program
    {
        private static string BinaryValue(int asciiValue)
        {
            string bin = "";

            while(asciiValue > 0)
            {
                bin = (asciiValue % 2).ToString() + bin;
                asciiValue /= 2;
            }

            bin = bin.PadLeft(8, '0');

            return bin;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string bin = "";

            for (int i = 0; i < s.Length; i++)
            {
                bin += BinaryValue(Convert.ToInt32(s[i])) + " ";
            }

            Console.WriteLine($"Binary value of string: {bin}");

            Console.ReadKey();
        }
    }
}
