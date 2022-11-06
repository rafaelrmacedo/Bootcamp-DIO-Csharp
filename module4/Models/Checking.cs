using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace module4.Models
{
    public class Checking : Account
    {
        public override void Credit(decimal value)
        {
            Balance += value;
        }
    }
}