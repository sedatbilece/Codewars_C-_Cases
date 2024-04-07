using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_C__Cases.Cases
{
    public class CompoundArray
    {

        public static int[] Solution(int[] a, int[] b)
        {

            int[] result = new int[a.Length + b.Length];
            int j = 0;
            var length = a.Length > b.Length ? a.Length : b.Length;
            for (int i = 0; i < length; i++)
            {
                if(i < a.Length)
                {
                    result[j] = a[i];
                    j++;
                }
                if(i < b.Length)
                {
                    result[j] = b[i];
                    j++;
                }
            }
            return result;
        }

    }
}
/*
You have to create a method "compoundArray" which should take as input two int arrays of different length and return one int array with numbers of both arrays shuffled one by one.

Input - {1,2,3,4,5,6} and {9,8,7,6} 
Output - { 1,9,2,8,3,7,4,6,5,6}
*/

