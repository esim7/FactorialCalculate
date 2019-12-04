using System;
using System.Collections.Generic;
using System.Linq;

namespace FactorialCalculate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = new List<string>();
            numbers = args.ToList();
        }
        public static string Factorial(List<string> args)
        {
            ulong result = 0;
            for (int j = 0; j < args.Count; j++)
            {
                ulong soloFactorial = 1;
                for (int i = 1; i <= int.Parse(args.ElementAt(j)); i++)
                {
                    soloFactorial *= (ulong)i;
                }
                result += soloFactorial;
            }
            return result.ToString();
        }
    }
}
