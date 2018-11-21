using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechProgLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intarr = {3, 5, 4, 2, 1};
            float[] floatarr = { 3.2f, 5.1f, 4.5f, 2.6f, 2.2f };
            string[] strarr = {"aa", "ab", "bb", "bc", "cc"};
            sort(intarr);
            sort(floatarr);
            sort(strarr);
            for (int i = 0; i < intarr.Length; i++) {
                Console.Write(intarr[i]);
                Console.Write(' ');
            }
            
            for (int i = 0; i < floatarr.Length; i++) {
                Console.Write(floatarr[i]);
                Console.Write(' ');
            }
            for (int i = 0; i < strarr.Length; i++)
                Console.Write(strarr[i] + ' ');
            Console.ReadKey();

        }

        static void sort(string[] intarr)
        {
            for (int i = 1; i < intarr.Length; i++)
            {
                for (int j = i - 1, k = i; j >= 0; j--)
                {
                    if (intarr[k].CompareTo(intarr[j]) > 1)
                    {
                        string temp = intarr[k];
                        intarr[k] = intarr[j];
                        intarr[j] = temp;
                        k = j;
                    }
                }
            }
        }

        static void sort(int[] intarr)
        {
            for (int i = 1; i < intarr.Length; i++) {
                for (int j = i - 1, k = i; j >= 0; j--)
                {
                    if (intarr[k] < intarr[j])
                    {
                        int temp = intarr[k];
                        intarr[k] = intarr[j];
                        intarr[j] = temp;
                        k = j;
                    }
                }
            }
        }

        static void sort(float[] intarr)
        {
            for (int i = 1; i < intarr.Length; i++)
            {
                for (int j = i - 1, k = i; j >= 0; j--)
                {
                    if (intarr[k] < intarr[j])
                    {
                        float temp = intarr[k];
                        intarr[k] = intarr[j];
                        intarr[j] = temp;
                        k = j;
                    }
                }
            }
        }
    }
}
