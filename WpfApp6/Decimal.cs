using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NumberConversionApp
{
    public class DecimalNumber : Integer
    {
        public DecimalNumber(int value) : base(value)
        {
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}

