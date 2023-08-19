using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    public struct Person
    {
        public int roll = 0;
        public readonly int _id;
        public string Name { get; set; }
        public double Age { get; set; }

        public Person(int id)
        {
            _id = id;
        }
        public void Talk(string message)
        {
            Console.WriteLine(message);
        }
    }
}
