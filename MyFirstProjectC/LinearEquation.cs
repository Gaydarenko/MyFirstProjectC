using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectC
{
    // 16th lesson
    public static class LinearEquation
    {
        // 1
        public static int ReadIntFromConsole()
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
        public static void SolveEquation()
        {
            int a = ReadIntFromConsole();
            int b = ReadIntFromConsole();
            int c = ReadIntFromConsole();
            int res = FindX(a, b, c);
            WriteIntToConsole(res);
        }
        public static int FindX(int a, int b, int c)
        {
            return (c - b) / a;
        }
        public static void WriteIntToConsole(int res)
        {
            Console.WriteLine($"Результат = {res}");
        }
        // 2
        public static void SolveSumMultDif()
        {
            int a = ReadIntFromConsole();
            int b = ReadIntFromConsole();
            int res;
            if (a > b)
            {
                res = FindSum(a, b);
            }
            else if (a == b)
            {
                res = FindMult(a, b);
            }
            else
            {
                res = FindDif(a, b);
            }
            WriteIntToConsole(res);
        }
        public static int FindSum(int a, int b)
        {
            return a + b;
        }
        public static int FindMult(int a, int b)
        {
            return a * b;
        }
        public static int FindDif(int a, int b)
        {
            return a - b;
        }
        // 3
        public static string ConvertTwoDigitNumberToString(int number)
        {
            string num_str = "";
            if (number < 20)
                switch (number)
                {
                    case 10:
                        num_str = "десять";
                        break;
                    case 11:
                        num_str = "одинадцать";
                        break;
                    case 12:
                        num_str = "двенадцать";
                        break;
                    case 13:
                        num_str = "тринадцать";
                        break;
                    case 14:
                        num_str = "четырнадцать";
                        break;
                    case 15:
                        num_str = "пятнадцать";
                        break;
                    case 16:
                        num_str = "шестнадцать";
                        break;
                    case 17:
                        num_str = "семнадцать";
                        break;
                    case 18:
                        num_str = "восемнадцать";
                        break;
                    case 19:
                        num_str = "девятнадцать";
                        break;
                }
            else
                switch (number % 10)
                {
                    case 1:
                        num_str = "один";
                        break;
                    case 2:
                        num_str = "два";
                        break;
                    case 3:
                        num_str = "три";
                        break;
                    case 4:
                        num_str = "четыре";
                        break;
                    case 5:
                        num_str = "пять";
                        break;
                    case 6:
                        num_str = "шесть";
                        break;
                    case 7:
                        num_str = "семь";
                        break;
                    case 8:
                        num_str = "восемь";
                        break;
                    case 9:
                        num_str = "девять";
                        break;

                }
            string dec_str = "";
            int dec = number / 10;
            switch (dec)
            {
                case 2:
                    dec_str = "Двадцать";
                    break;
                case 3:
                    dec_str = "Тридцать";
                    break;
                case 4:
                    dec_str = "Сорок";
                    break;
                case 5:
                    dec_str = "Пятьдесят";
                    break;
                case 6:
                    dec_str = "Шестьдесят";
                    break;
                case 7:
                    dec_str = "Семьдесят";
                    break;
                case 8:
                    dec_str = "Восемьдесят";
                    break;
                case 9:
                    dec_str = "Девяносто";
                    break;
            }
            string res = dec_str + " " + num_str;
            return res;
        }
        public static void GetStringFromDigit()
        {
            int num = ReadIntFromConsole();
            string res = ConvertTwoDigitNumberToString(num);
            Console.WriteLine(res);
        }
        // 4
        public static void CheckNumInFIXRanges()
        {
            int num = ReadIntFromConsole();
            Console.WriteLine((0 < num && num < 10 || 20 < num && num < 30 || 40 < num && num < 50) ? true : false);
        }
        // 5
        public static int FindRangesSum(int a, int b)
        {
            int start = FindStartNumber(a, 7);
            int sum = 0;
            for (int i = start; i <= b; i += 7)
            {
                sum += i;
            }
            return sum;
        }
        public static int FindStartNumber(int a, int step)
        {
            int start;
            if (a % step == 0)
            {
                start = a;
            }
            else
            {
                start = (a / step + 1) * step;
            }
            return start;
        }
        public static void SolveRangesSum()
        {
            int a = ReadIntFromConsole();
            int b = ReadIntFromConsole();
            int res = FindRangesSum(a, b);
            WriteIntToConsole(res);
        }
        // 6
        public static int FindFibonachiNum(int num)
        {
            int a = 1;
            int b = 1;
            int c;
            if (num > 2)
            {
                for (int i = 3; i <= num; i++)
                {
                    c = a;
                    a = b;
                    b = a + c;
                }
            }
            return b;
        }
        public static void GetFibonachiNum()
        {
            int num = ReadIntFromConsole();
            int res = FindFibonachiNum(num);
            WriteIntToConsole(res);
        }
        // 7
        public static int CountOdd(int num)
        {
            int count = 0;
            while (num != 0)
            {
                int tmp = num % 10;
                if (tmp % 2 != 0)
                {
                    count++;
                }
                num /= 10;
            }
            return count;
        }
        public static void GetCountOdd()
        {
            int num = ReadIntFromConsole();
            int res = CountOdd(num);
            WriteIntToConsole(res);
        }
        // 8
        public static string MirrorNumber(int num)
        {
            string res = "";
            while (num != 0)
            {
                res += Convert.ToString(num % 10);
                num = num / 10;
            }
            return res;
        }
        public static void GetMirrowNumber()
        {
            int num = ReadIntFromConsole();
            string res = MirrorNumber(num);
            Console.WriteLine(res);
        }
        // 9
        public static bool Compare(int a, int b)
        {
            bool flag = false;
            do
            {
                int i = a % 10;
                a /= 10;
                int tmp = b;
                do
                {
                    int j = tmp % 10;
                    tmp /= 10;
                    if (i == j)
                    {
                        flag = true;
                    }
                }
                while (tmp > 0);

            }
            while (a > 0);
            return flag;
        }
        public static void CompareTwoNumbers()
        {
            int a = ReadIntFromConsole();
            int b = ReadIntFromConsole();
            bool res = Compare(a, b);
            Console.WriteLine(res);
        }
    }
    // 17th lesson 
    public static class ActionsWithArrays
    {
        // 16th lesson
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
        // 17th lesson
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
            int finish = nums.Length-1;
            while (finish > 0)
            {
                for (int i = 0; i < finish; i++)
                {
                    if (nums[i] > nums[i+1])
                    {
                        int tmp = nums[i];
                        nums[i] = nums[i+1];
                        nums[i+1] = tmp;
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
    }
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
            for (int i = 0; i < nums.GetLength(0)-1; i++)
            {
                for (int j = 1; j < nums.GetLength(1); j++)
                {
                    if ((nums[i, j] > nums[i, j-1]) && (nums[i, j] > nums[i+1, j]))
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
