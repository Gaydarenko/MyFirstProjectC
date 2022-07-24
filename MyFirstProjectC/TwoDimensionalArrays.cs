using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectC
{
    public static class TwoDimensionalArrays
    {
        public static int[,] GenerateArray(int rows, int columns, int start, int finish)
        {
            int[,] nums = new int[rows, columns];
            Random r = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    nums[i, j] = r.Next(start, finish);
                }
            }
            return nums;
        }
        public static void WriteTDArray(int[,] nums)
        {
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.Write($"{nums[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        public static void WriteResult(int num)
        {
            Console.WriteLine($"{num}");
        }
        public static int MinElement(int[,] nums)
        {
            int num = nums[0, 0];
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    if (nums[i, j] < num)
                    {
                        num = nums[i, j];
                    }
                }
            }
            return num;
        }
        //public static void TestMinElement()
        //{
        //    int[,] test_arr = GenerateArray(3, 4, 10, 100);
        //    WriteArray(test_arr);
        //    int num = MinElement(test_arr);
        //    Console.WriteLine(num);
        //}
        public static int MaxElement(int[,] nums)
        {
            int num = nums[0, 0];
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    if (nums[i, j] > num)
                    {
                        num = nums[i, j];
                    }
                }
            }
            return num;
        }
        public static int[] IndexMinElement(int[,] nums)
        {
            int x = 0;
            int y = 0;
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    if (nums[i, j] < nums[x, y])
                    {
                        x = i;
                        y = j;
                    }
                }
            }
            return new int[] { x, y };
        }
        public static int[] IndexMaxElement(int[,] nums)
        {
            int x = 0;
            int y = 0;
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    if (nums[i, j] > nums[x, y])
                    {
                        x = i;
                        y = j;
                    }
                }
            }
            return new int[] { x, y };
        }
        public static int CountElements(int[,] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < nums.GetLength(1); j++)
                {
                    if ((nums[i, j] > nums[i, j - 1]) && (nums[i, j] > nums[i + 1, j]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static void TestMethods()
        {
            int[,] test_arr = GenerateArray(3, 4, 10, 100);
            WriteTDArray(test_arr);
            int min = MinElement(test_arr);
            Console.WriteLine($"min = {min}");
            int max = MaxElement(test_arr);
            Console.WriteLine($"max = {max}");
            int[] ind_min = IndexMinElement(test_arr);
            Console.WriteLine($"ind_min_el = [{ind_min[0]}, {ind_min[1]}]");
            int[] ind_max = IndexMaxElement(test_arr);
            Console.WriteLine($"ind_max_el = [{ind_max[0]}, {ind_max[1]}]");
            int count = CountElements(test_arr);
            Console.WriteLine($"count = {count}");
        }

    }
}
