using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Constructors_and_Deconstructors
{
    public class Person
    {
        public string Name;
        public int Age;
        public double Stature;

        public Person(string name, int age, double stature) 
        {
            Name = name;
            Age = age;
            Stature = stature;
        }

        public void Presentation()
        {
            Console.WriteLine("Hi, i am " + Name +" i have "+ Age+ " years");
        }

        ~Person() // Descontructors
        {
            Console.WriteLine($"The object {Name} has been destroyed.");
        }
    }
}
