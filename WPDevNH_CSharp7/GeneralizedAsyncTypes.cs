using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPDevNH_CSharp7
{
    class GeneralizedAsyncTypes: Example
    {

        /// <summary>
        /// performance improvement over Task<T>
        /// </summary>
        /// <returns></returns>
        public async ValueTask<int> Func()
        {
            await Task.Delay(100);
            return 5;
        }


    }
}
