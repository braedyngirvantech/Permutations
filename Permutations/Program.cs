using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutations
{
    class Program
    {
        private static void Swap(ref int a, ref int b)
        {
            if (a == b) return;

            a ^= b;
            b ^= a;
            a ^= b;
        }

        public static void GetPer(int[] list)
        {
            int x = list.Length - 1;
            GetPer(list, 0, x);
        }

        private static void GetPer(int[] list, int k, int m)
        {
            if (k == m)
            {
                foreach (int print in list)
                Console.Write(print);
                Console.WriteLine();
            }
            else
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    GetPer(list, k + 1, m);
                    Swap(ref list[k], ref list[i]);
                }
        }

        static void Main(string[] args)
        {
            string str = "bcd";
            int[] arr = new int[] { 1, 2, 3, 4 };// str.ToCharArray();
            GetPer(arr);
            Console.ReadLine();
        }
    }
}
