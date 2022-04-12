using System;

namespace A_to_B_B_to_A

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Swap swap = new Swap();

            swap.ReadNumbers();
            swap.SwapNumbers();
            swap.Print();
        }

        public class Swap
        {
            int a, b;

            public void Print()
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
            }

            public void ReadNumbers()
            {
                Console.WriteLine("Enter A and press ENTER...");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter B and press ENTER...");
                b = Convert.ToInt32(Console.ReadLine());
            }

            public void SwapNumbers()
            {
                int c;
                c = a;
                a = b;
                b = c;
            }
        }
    }
}
        
