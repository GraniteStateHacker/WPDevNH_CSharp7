using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPDevNH_CSharp7
{
    class RefLocalsAndReturns: Example
    {
        public static (int i, int j) Find(int[,] matrix, Func<int, bool> predicate)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                if (predicate(matrix[i, j]))
                    return (i, j);
            return (-1, -1); // Not found
        }

        public static void UseFind()
        {
            var matrix = new int[10,10];
            var indices = Find(matrix, (val) => val == 42);
            WriteLine(indices);
            matrix[indices.i, indices.j] = 24;
        }




        public static ref int Find3(int[,] matrix, Func<int, bool> predicate)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                if (predicate(matrix[i, j]))
                    return ref matrix[i, j];
            throw new InvalidOperationException("Not found");
        }

        public static void UseFind3()
        {
            var matrix = new int[10,10];
            var valItem = Find3(matrix, (val) => val == 42);
            WriteLine(valItem);
            valItem = 24;
            WriteLine(matrix[4, 2]);
        }
    }
}
