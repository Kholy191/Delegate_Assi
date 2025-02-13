using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{

    public delegate T CompareNum<in T1 ,in T2 ,out T>(T1 a, T2 b);
    internal class SortingArray <T>
    {
        
        static public void SortingArrayFunc(T[] Arr , CompareNum<T , T , bool> Func)
        {
            if (Arr?.Length > 0 && Func is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if ( Func(Arr[j], Arr[j+1]) )
                        {
                            Swap(ref Arr[j], ref Arr[j + 1]);
                        }
                    }
                }
            }
        }

        private static void Swap(ref T v1, ref T v2)
        {
            T Temp = v1;
            v1 = v2;
            v2 = Temp;
        }
    }
}
