﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Person
    {
        public Person()
        {
            Name = "No name";
            Age = 1;
        }
        public Person(int age) :this()
        {
            Age = age;
        }
        public Person(string name, int age) :this(age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}
