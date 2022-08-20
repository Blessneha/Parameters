using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    internal class Q2
    {
        public void sol2(string s)
        {
            string[] arr = s.Split(' ');
            int cou = arr.Length;
           int[]frr=new int[cou];
            int c = 0;
            for(int i=0;i< cou; i++)
            {
                frr[i] = -1;
            }
            int k, r;
            for (k = 0; k < cou; k++)
            {
                c = 1;
                for (r = k + 1; r < cou; r++)
                {
                    if (arr[k] == arr[r])
                    {
                        frr[r] = 0;
                        c++;
                    }



                }
                if (frr[k]!=0)
                {
                    frr[k] = c;
                }

            }
            Console.WriteLine("The number of words is: " + cou);
            for(int h=0;h<cou; h++)
            {
                if (frr[h] != 0)
                {
                    Console.WriteLine($"the number of times {arr[h]} occurs is {frr[h]}");
                }

            
}
        }
    }
}
