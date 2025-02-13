using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public static class SortMethods
    {
        static public bool SortASC(int X , int Y)
        {
            return X > Y;
        }

        static public bool SortDes(int X, int Y)
        {
            return X < Y;
        }

        static public bool SortASC(string X, string Y)
        {
            return X?.Length > Y?.Length;
        }

        static public bool SortDes(string X, string Y)
        {
            return X?.Length < Y?.Length;
        }
    }
}
