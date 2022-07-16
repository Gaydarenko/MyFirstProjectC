using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectC
{
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
}
