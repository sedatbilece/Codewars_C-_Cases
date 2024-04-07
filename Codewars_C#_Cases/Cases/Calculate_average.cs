using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_C__Cases.Cases
{
    public class Calculate_average
    {

        public static double FindAverage(double[] array)
        {
            if(array.Length == 0)
            {
                return 0;
            }
            double sum = 0;
            for(int i = 0; i < array.Length; i++)
            {               
                sum+= array[i];
            }
            return sum/array.Length;
        }
    }
}

/*
Write a function which calculates the average of the numbers in a given list.

Note: Empty arrays should return 0.
*/