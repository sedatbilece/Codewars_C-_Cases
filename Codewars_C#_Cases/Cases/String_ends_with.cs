using System.Numerics;

namespace Codewars_C__Cases.Cases
{
    public class String_ends_with
    {

        public static bool Solution(string str, string ending)
        {

            if (str.Length < ending.Length)
                return false;

            var check = str.Substring(str.Length - ending.Length);

            if (check != ending)
                return false;

            return true;
        }
    }
}

/*
Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string).

Examples:

solution('abc', 'bc') // returns true
solution('abc', 'd') // returns false
*/
