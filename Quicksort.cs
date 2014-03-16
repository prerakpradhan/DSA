using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm
{


    class Quicksort
    {
        public int partition(int[] a, int l, int h)
        {
            int x = a[h];
            int i = l - 1;
            for (int n = l; n <= h-1; n++)
            {
                if (a[n] <= x)
                {
                    i++;
                    int tmp = a[i];
                    a[i] = a[n];
                    a[n]= tmp;
                }
            }

            int tmpe = a[i+1];
            a[i + 1] = a[h];
            a[h] = tmpe;
            return (i + 1);
                


            
        }

        public void quicksrt(int[] a, int l, int h)
        {
            if (l >= h)
                return;

            int pivot = partition(a, l, h);
            quicksrt(a, l, pivot-1);
            quicksrt(a, pivot + 1, h);



        }

    }
}
