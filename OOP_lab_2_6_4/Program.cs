using System;

namespace OOP_lab_2_6_4
{
    public class Program
    {
        public static int NegativeCount(int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] < 0)
                {
                    ++count;
                }
            }

            return count;
        }

        public static int IndexOfMinAbs(int[] array)
        {
            int index = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                if (Math.Abs(array[index]) >= Math.Abs(array[i]))
                {
                    index = i;
                }
            }

            return index;
        }

        public static int Sum(int[] array)
        {
            int sum = 0;

            for (int i = IndexOfMinAbs(array) + 1; i < array.Length; ++i)
            {
                sum += array[i];
            }

            return sum;
        }

        static void Main()
        {
            int[] array = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < array.Length; ++i)
            {
                Console.Write("a[{0}] = ", i);

                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Kiлькiсть вiд’ємних елементiв масиву: {0}", NegativeCount(array));
            Console.WriteLine("Cумa елементiв масиву, розташованих пiсля мiнiмального за модулем елемента: {0}", Sum(array));
        }
    }
}
