using System;

namespace ArrayReplacement1
{
    public class Program
    {
        public static void Main()
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] <= 0)
                    Console.WriteLine("X[" + i + "] = " + 1);
                else
                    Console.WriteLine("X[" + i + "] = " + array[i]);
            }
            Console.ReadKey();
        }
    }
}
