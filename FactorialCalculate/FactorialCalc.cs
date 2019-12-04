using System;
using System.Collections.Generic;
using System.Text;

namespace FactorialCalculate
{
    public class FactorialCalc
    {
        public int Calculate(List<string> args)
        {
            var result = 0;
            for (int i = 0; i < args.Count; i++)
            {
                result += int.Parse(args[i]);
            }
            return result;
        }
    }
}
