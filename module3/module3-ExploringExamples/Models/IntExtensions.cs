using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace module3_ExploringExamples.Models
{
    public static class IntExtensions
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
    }
}