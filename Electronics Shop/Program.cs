//Finished in 2 minutes.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronics_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLineInput = Console.ReadLine().Split(' ');
            int b = int.Parse(firstLineInput[0]);
            int m = int.Parse(firstLineInput[1]);
            int n = int.Parse(firstLineInput[2]);

            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), t => Convert.ToInt32(t));
            int[] usbs = Array.ConvertAll(Console.ReadLine().Split(' '), t => Convert.ToInt32(t));

            int result = GetMoneySpent(keyboards, usbs, b);
            Console.WriteLine(result);
        }

        static int GetMoneySpent(int[] key, int[] usb, int b)
        {
            List<int> amount = new List<int>();
            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < usb.Length; j++)
                {
                    if (key[i] + usb[j] <= b)
                        amount.Add(key[i] + usb[j]);
                }
            }
            int r = amount.Count != 0 ? amount.Max() : -1;
            return r;
        }
    }
}
