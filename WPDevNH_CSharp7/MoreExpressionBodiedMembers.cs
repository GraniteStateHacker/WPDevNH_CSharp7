using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPDevNH_CSharp7
{
    class MoreExpressionBodiedMembers:Example
    {
         private string label;
        
        // Expression-bodied constructor
        public MoreExpressionBodiedMembers(string label) 
            => this.Label = label;

        // Expression-bodied finalizer
        ~MoreExpressionBodiedMembers() 
            => WriteLine("Finalized!");



        // Expression-bodied get / set accessors.
        public string Label
        {
            get => label;
            set => this.label = value ?? "Default label";
        }

    }
}
