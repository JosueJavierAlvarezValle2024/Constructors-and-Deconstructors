using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Constructors_and_Deconstructors
{
    public class Estudent : Person
    {
        public string Sex;
        public string Career;
        public Estudent(string name, int age, double stature, string sex , string career) : base(name, age, stature)
        {
            Sex = sex;
            Career = career;
        }

        public void StudentPresentation()
        {
            Console.WriteLine(Name+ " is studying in the career of "+ Career);
        }
    }
}
