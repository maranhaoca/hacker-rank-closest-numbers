using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
        /*
         * Complete the 'closestNumbers' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static List<int> closestNumbers(List<int> arr)
        {
            List<int> returnArr = new List<int>();
            int dif = 100000;
            arr.Sort();

            for (int i = 0; i < arr.Count -1; i++)
            {
                if (Math.Abs(arr[i] - arr[i+1]) < dif)
                {
                    dif = Math.Abs(arr[i] - arr[i+1]);
                    returnArr.Clear();
                    returnArr.Add(arr[i]);
                    returnArr.Add(arr[i+1]);
                } else if (Math.Abs(arr[i] - arr[i+1]) == dif)
                {
                    returnArr.Add(arr[i]);
                    returnArr.Add(arr[i+1]);
                }

            }

            return returnArr;
        }
    }
}