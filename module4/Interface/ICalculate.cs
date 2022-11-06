using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace module4.Interface
{
    public interface ICalculate
    {
        //The C# understand the method is public without declare the method as public
        int Add(int number1, int number2);
        int Substract(int number1, int number2);
        int Multiplicate(int number1, int number2);
        int Division(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}