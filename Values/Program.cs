using System;
using System.Linq;

namespace Values
{
    class Program
    {
        public static int globalValue = 3;
        static void Main(string[] args)
        {
            int[] vect = new int[] { 3, 4, 5 };
            ChangeOddValues(vect);
            //var a = vect.TakeWhile(n => n < 3);
            Console.WriteLine(string.Join(" ", vect));
            //Console.WriteLine(string.Join(" ", a));

            int[] numbers = { 5, 4, 9, 1, 3, 9, 8, 6, 7, 2, 0 };
            var firstSmallNumbers = numbers.TakeWhile((n, index) => n >= index); //pega os valores no array enquanto o numero for maior que o index
            Console.WriteLine(string.Join(" ", firstSmallNumbers));
            // Output:
            // 5 4
        }
        public static void ChangeOddValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers[i] += globalValue;
                }
            }
        }
    }
}
