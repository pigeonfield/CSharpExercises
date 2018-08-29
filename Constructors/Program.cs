using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();                                               //first type of ctor

            Person person2 = new Person(2, "Tom");                                       //second type of ctor

            Person person3 = new Person(3, "Tom", "Brown");                              //third type of ctor

            Person person4 = new Person(4, "Tomek", "Brown", "Boston", 18, "male");      //fourth type of ctor
        }
    }
}
