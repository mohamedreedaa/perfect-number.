using System;

namespace perfect_number
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter start number");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("enter end number ");
            int end = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int x = start ; x <= end ; x++) 
            {
                for (int y = 1; y <= x/2; y++)
                {
                    if (y < x)
                    {
                        if (x % y == 0)
                            sum += y;
                    }
                }
                if (sum ==x )
                {
                    Console.WriteLine(x);
                }
                sum = 0;
            }
            return;

           
        }
    }
}
