using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace module3_ExploringExamples.Models
{
    public class ExamplesException
    {
        public void Method1()
        {
            Method2();
        }

        public void Method2()
        {
            Method3();
        }

        public void Method3()
        {
            Method4();
        }

        public void Method4()
        {
            throw new Exception("A generic exception occurred.");
        }
    }
}