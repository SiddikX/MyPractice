using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifier
{
    public class TestClass
    {
        public int Sum(params int[] items)
        {
            var sum = 0;
            foreach (var item in items)
            {
                sum += item;
            }
            return sum;
        }
    }
}
