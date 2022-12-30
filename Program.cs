using System;

namespace prime_nombre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbre");
            Console.WriteLine("enter first nombre");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter seconde nombre");
            int num2 = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = num1; i <= num2; i++) 
            {
                for (int x = 1; x <=i; x++)
                {
                    if (i%x==0)
                    {
                        sum++;
                    }
                }
                if (sum == 2)
                {
                    Console.WriteLine(i);
                    sum = 0;
                }
                else
                {
                    sum = 0;
                }
                {
                    continue;
                }
            }
        }
    }
}
