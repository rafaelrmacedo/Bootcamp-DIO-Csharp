using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using module4.Interface;

namespace module4.Models
{
    public class Calculate : ICalculate 
    {
        int ICalculate.Add(int number1, int number2)
        {
            return number1 + number2;
        }

        int Add(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }

        // int ICalculate.Division(int number1, int number2)
        // {
        //     return number1 / number2;
        // }

        int ICalculate.Multiplicate(int number1, int number2)
        {
            return number1 * number2;
        }

        int ICalculate.Substract(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}