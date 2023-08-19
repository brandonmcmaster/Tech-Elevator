using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExample
{
    public class Pet
    {
       public string name;
       public int age;
        public string type;

        public override string ToString()
        {
            return $"{name} - {age} - {type}";
        }
    }
}
