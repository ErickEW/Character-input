using System;

namespace Even_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 10; i++)
            if (i % 2 == 0){
                Console.WriteLine(i);
            }
        }
    }
}
