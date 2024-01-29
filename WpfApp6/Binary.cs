using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;

namespace NumberConversionApp
{
    public class BinaryNumber : Integer
    {
        public BinaryNumber(int value) : base(value)
        {
        }

        public override string ToString()
        {
            return Convert.ToString(Value, 2);
        }
    }
}

