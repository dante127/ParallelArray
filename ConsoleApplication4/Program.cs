using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace SplitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < s; i++)
            {
                x[i] = i;
                sum += x[i];
            }
            Console.WriteLine("sum : =  " + sum / s);
            Thread th = new Thread(() => sp(0));
            Thread th2 = new Thread(() => sp(1));
            th.Start();
            th2.Start();
            th.Join();
            th2.Join();
            Console.WriteLine("final " + a / 2);
        }
        static double a = 0;
        static int s = 10;
        static int[] x = new int[s];
        static void sp(int idx)
        {
            object o = new object();
            
                int n = s / 2;
                int low = (idx * n);
                int h = (low + n);
                int sum = 0;
                for (int i = low; i < h; i++)
                {
                    sum += x[i];
                }
                a+= sum / n;
                Console.WriteLine(sum / n);
            
        }
    }
}
