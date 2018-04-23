using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GridSample
{
    public class Customer
    {
        string name;
        int age;
        int weight;

        public string Name{
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }

}
