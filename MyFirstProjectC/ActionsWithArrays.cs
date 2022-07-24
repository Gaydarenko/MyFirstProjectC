using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectC
{
    // 17th & 18th lessons
    public static class ActionsWithArrays
    {
        // 17th lesson
        public static int MinInArray(int[] nums)
        {
            int min = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (min > nums[i])
                {
                    min = nums[i];
                }
            }
            return min;
        }
        public static int MaxInArray(int[] nums)
        {
            int max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (max < nums[i])
                {
                    max = nums[i];
                }
            }
            return max;
        }
        public static int IndexMinInArray(int[] nums)
        {
            int ind_min = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[ind_min] > nums[i])
                {
                    ind_min = i;
                }
            }
            return ind_min;
        }
        public static int IndexMaxInArray(int[] nums)
        {
            int ind_max = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[ind_max] < nums[i])
                {
                    ind_max = i;
                }
            }
            return ind_max;
        }
        public static int SumNumbersWithOddInex(int[] nums)
        {
            int res = 0;
            for (int i = 1; i < nums.Length; i += 2)
            {
                res += nums[i];
            }
            return res;
        }
        public static int[] ReverseArray(int[] nums)
        {
            int[] res = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
                res[nums.Length - 1 - i] = nums[i];
            return res;
        }
        public static int CountOdd(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] % 2 == 0)
                {
                    count++;
                }
            return count;
        }
        public static int[] ReverseHalfsArray(int[] nums)
        {
            int mid = nums.Length / 2 + 1;
            int[] res = new int[nums.Length];
            int j = 0;
            for (int i = mid; i < nums.Length; i++)
            {
                res[j++] = nums[i];
            }
            for (int i = 0; i < mid; i++)
            {
                res[j++] = nums[i];
            }
            return res;
        }
        // 18th lesson
        public static int[] GenerateArray(int len, int start, int finish)
        {
            Random num = new Random();
            int[] nums = new int[len];
            for (int i = 0; i < len; i++)
            {
                nums[i] = num.Next(start, finish + 1);
            }
            return nums;
        }
        public static void WriteArrayInLine(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]} ");
            }
            Console.WriteLine();
        }
        public static int[] BubbleSort(int[] nums)
        {
            int finish = nums.Length - 1;
            while (finish > 0)
            {
                for (int i = 0; i < finish; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        int tmp = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = tmp;
                    }
                }
                finish--;
            }
            return nums;
        }
        public static void TestBubbleSort()
        {
            int[] nums = GenerateArray(6, -100, 100);
            Console.Write("Source: ");
            WriteArrayInLine(nums);
            BubbleSort(nums);
            Console.Write("Result: ");
            WriteArrayInLine(nums);
        }
        public static int[] SelectionSort(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int min = nums[i];
                int ind = i;
                for (int j = i + 1; j < nums.Length; j++)
                    if (nums[j] < min)
                    {
                        min = nums[j];
                        ind = j;
                    }
                nums[ind] = nums[i];
                nums[i] = min;
            }
            return nums;
        }
        public static void TestSelectionSort()
        {
            int[] nums = GenerateArray(10, -100, 100);
            Console.Write("Source: ");
            WriteArrayInLine(nums);
            SelectionSort(nums);
            Console.Write("Result: ");
            WriteArrayInLine(nums);
        }

    }
}
