using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 9, 8, 4, 3, 1, 6, 7 };
           BubbleSort( arr);
            PrintArr(arr);
        }

         static void BubbleSort( int[] arr)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1; j < arr.Length ; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        SortArr( ref arr[i], ref arr[j]);
                    }
                }

            }
            
            
        }


        static void SortArr(ref int v1,  ref int v2)
        {
            int temp = 0;

            temp = v1;
            v1 = v2;
            v2 = temp;
        }

        static void PrintArr(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }

    }

}
