using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPDevNH_CSharp7
{
    class ThrowExpressions:Example
    {
        private string name;

        public string Name
        {
            get => name;
            set => name = value ??
                          throw new ArgumentNullException(paramName: nameof(value), message: "New name must not be null");
            // like a typical throw statement, except that it's used as an expression in the ?? operator.
        }

    }
}
