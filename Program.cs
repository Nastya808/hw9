using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace hw9
{

    //Інтерфейс ICalc
    public interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }

    public class MyArray : ICalc
    {
        private int[] data;

        public MyArray(int[] values)
        {
            data = values;
        }

        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (int item in data)
            {
                if (item < valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (int item in data)
            {
                if (item > valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }

    //Інтерфейс IOutput2
    public interface IOutput2
    {
        void ShowEven();
        void ShowOdd();
    }

    public class MyArray : ICalc, IOutput2
    {
        private int[] data;

        public MyArray(int[] values)
        {
            data = values;
        }

        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (int item in data)
            {
                if (item < valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (int item in data)
            {
                if (item > valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public void ShowEven()
        {
            Console.WriteLine("Парні значення:");
            foreach (int item in data)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void ShowOdd()
        {
            Console.WriteLine("Непарні значення:");
            foreach (int item in data)
            {
                if (item % 2 != 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            MyArray array = new MyArray(values);

            int lessCount = array.Less(5);
            int greaterCount = array.Greater(5);
            Console.WriteLine($"Кількість чисел менших за 5: {lessCount}");
            Console.WriteLine($"Кількість чисел більших за 5: {greaterCount}");


            array.ShowEven();
            array.ShowOdd();
        }
    }
}
