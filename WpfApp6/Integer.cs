using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConversionApp
{
    public abstract class Integer
    {
        protected int Value;

        public Integer(int value)
        {
            Value = value;
        }

        public abstract override string ToString();
    }
}
