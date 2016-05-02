using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogRiver
{
    class Program
    {
        static int CrossTheRiver(int X, int[] A)
        {
            HashSet<int> positions = new HashSet<int>(Enumerable.Range(1,X));
            for( int i = 0; i < A.Length; ++i)
            {
                positions.Remove(A[i]);
                if (positions.Count == 0)
                    return i;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            // Should be 6
            int[] A = {1, 3, 1, 4, 2, 3, 5, 4};
            Console.Out.WriteLine(CrossTheRiver(5, A));

            // should be 0
            int[] A2 = { 1 };
            Console.Out.WriteLine(CrossTheRiver(1, A2));

            // should be -1
            int[] A3 = { 1, 1 };
            Console.Out.WriteLine(CrossTheRiver(2, A2));
        }
    }
}
