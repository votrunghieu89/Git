using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGit
{
    public class Demo5
    {
        public int Modulo(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot perform modulo by zero.");
            }
            return a % b;
        }
    }
}
