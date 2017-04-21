using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPDevNH_CSharp7
{
    class OutVariables: Example
    {


        public void Old()
        {

            int numericResult;   //Variable declared here
            if (int.TryParse(input, out numericResult))
                WriteLine(numericResult);
            else
                WriteLine("Could not parse input");
        }


        public void New()
        {

            if (int.TryParse(input, out int result))  //variable declared here, scoped the same
                WriteLine(result);
            else
                WriteLine("Could not parse input");
        }


        public void New_ImplicitlyTyped()
        {
            if (int.TryParse(input, out var answer))   //note the use of var instead of a specific type
                WriteLine(answer);
            else
                WriteLine("Could not parse input");
        }


        public int? New_ScopeExample()
        {
            if (!int.TryParse(input, out var result))  //declared here, inside an "if" test
            {
                return null;
            }

            return result;   //Note that scope of result 'leaked' into outer scope
        }

    }
}
