using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class BubbleSort<T>
    {
        public T[] Bubble(T[] arr, Func<T, T, bool> compare)
        {
            T temp;
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (compare(arr[i] , arr[i+1]))
                    {
                        temp = arr[i + 1];
                        arr[i+1] = arr[i];
                        arr[i] = temp;
                    }
                }

            }
            return arr;
        }
        
    }
}
