using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExam
{
    abstract class Person
    {
        public String name;
        public Person(string name)
        {
            this.name = name;
        }
        public Person() { }
    }
}
