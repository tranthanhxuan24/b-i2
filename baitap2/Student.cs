using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace bt2
{
    internal class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public Student() { }

        public override string ToString()
        {
            return $" {Id} , {Name}, {Age}";
        }
    }
}
