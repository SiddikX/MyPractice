using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExamples
{
    public class Pointer<T, Q>
        where T : struct
        where Q : class
    {
        public T X { get; set; }
        public Q Y { get; set; }

        public void Add<K> (K val)
        {
            K n1;
            T n2;
        }

    }
}
