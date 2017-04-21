
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPDevNH_CSharp7
{

    

    //Requires NuGet package "System.ValueTuple" for UWP, .NET Core, & .NET <= 4.6.2
    class Tuples : Example
    {

        public void ExampleOld()
        {

            Tuple<int, string> x;
            
        }

        public void Example()
        {

            var letters = ("a", "b");
            letters.Item1 = "c";

            var mixed = ("a", "b", 1);
            //mixed.Item3 = "";
            mixed.Item3 = 0;

            var (a, b, d) = resultOfFunction();
            //if (a == b)  breaks build because of type mismatch
            {
                
            }
        }



        public void Deconstruction()
        {
            var p = new Person("Althea", "Goodwin");
            var (first, last) = p;
            //first = "Althea"
            
        }

        private (int a, string b, bool c) resultOfFunction()   //'tuple your returns!
        {
            return (1, "hello", true);
        }



        private class Person
        {
            public string FirstName { get; }
            public string LastName { get; }

            public Person(string first, string last)
            {
                FirstName = first;
                LastName = last;
            }

            public void Deconstruct(out string firstName, out string lastName)  //"Deconstruct" is a special operation
            {
                firstName = FirstName;
                lastName = LastName;
            }
        }
    }
}
