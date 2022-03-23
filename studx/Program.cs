using System;

namespace stud1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int min = 0;
            for (int i = 158928; i <= 345293; i++)  
            {
                for (int d = 2; d <= Math.Sqrt(i); d++) 
                {
                    if (i % d == 0)
                    {
                        int anotherD = i / d;
                        if (isPrime(d) == true)
                        {
                            for (int x = 2; x <= Math.Sqrt(anotherD); x++)
                            {
                                if (anotherD % x == 0 && x != d)
                                {
                                    int anotherX = anotherD / x;
                                    if (isPrime(x) == true && isPrime(anotherX) == true && anotherX != d && anotherX != x)
                                    {
                                        count++;
                                        if (min == 0) min = i;
                                        Console.WriteLine("Добавили " + i + " т.к. " + d + " " + x + " " + anotherX);
                                        d = i;

                                    }
                                }


                            }

                        }
                    }
                }
            }
            Console.WriteLine(count + " " + min);
        }

        static bool isPrime(int x)
        {
            for (int y = 2; y <= Math.Sqrt(x); y++)
            {
                if (x % y == 0) return false;
            }
            return true;

        }
    }
}
