// 5 lesson
//Console.WriteLine("Как Вас зовут?");
//string firstName = Console.ReadLine();
//string hello = "Привет, " + firstName + "!!!";
//Console.WriteLine(hello);

//Console.WriteLine("Какая у Вас фамилия?");
//string lastName = Console.ReadLine();
//Console.WriteLine("А какое у Вас отчество?");
//string middleName = Console.ReadLine();
//string fullName = lastName + " " + firstName + " " + middleName;
//Console.WriteLine(fullName);


// 6th lesson
// 1
//Console.WriteLine("A =");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("B =");
//double b = Convert.ToDouble(Console.ReadLine());
//string res = "A * B =" + Convert.ToString(a * b);
//Console.WriteLine(res);
//res = "A % B =" + Convert.ToString(b % a);
//Console.WriteLine(res);
// 2
//Console.WriteLine("A =");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("B =");
//double b = Convert.ToDouble(Console.ReadLine());
//double c = a;
//a = b;
//b = c;
// 3
//Console.WriteLine("A =");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("B =");
//double b = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("C =");
//double c = Convert.ToDouble(Console.ReadLine());
//string res = Convert.ToString((c - b) / a);
//Console.WriteLine("X = " + res);


// 7th lesson
// 1
//Console.WriteLine("Enter password:");
//string pass = Console.ReadLine();
//if (pass == "QWERTY123") Console.WriteLine("You guessed pass");
//else Console.WriteLine("You didn't guess right");
// 2
//Console.WriteLine("A =");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("B =");
//double b = Convert.ToDouble(Console.ReadLine());
//double res;
//if (a > b) res = a + b;
//else if (a == b) res = a * b;
//else res = a - b;
//Console.WriteLine(res);
// 3
//Console.WriteLine("Enter a number");
//double a = Convert.ToDouble(Console.ReadLine());
//if (a % 2 == 0) Console.WriteLine("Четное");


// 8th lesson
// 1
//Console.WriteLine("Enter a number");
//double a = Convert.ToDouble(Console.ReadLine());
//if (a % 2 == 0) Console.WriteLine("Четное");
//else Console.WriteLine("Нечетное");
// 2
//Console.WriteLine("A =");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("B =");
//double b = Convert.ToDouble(Console.ReadLine());
//if (a > b) Console.WriteLine("A > B на " + Convert.ToString(a - b));
//else if (a < b) Console.WriteLine("B > A на " + Convert.ToString(b - a));
//else Console.WriteLine("A и В равны");
// 3
//Console.WriteLine("A =");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("B =");
//double b = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("C =");
//double c = Convert.ToDouble(Console.ReadLine());
//if (a > b)
//    if (a > c)
//        if (b > c) Console.WriteLine(c + " " + b + " " + a);
//        else Console.WriteLine(b + " " + c + " " + a);
//    else Console.WriteLine(b + " " + a + " " + c);
//else if (b > c)
//    if (a > c) Console.WriteLine(c + " " + a + " " + b);
//    else Console.WriteLine(a + " " + c + " " + b);
//else Console.WriteLine(a + " " + b + " " + c);
// 4
//Console.WriteLine("A =");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("B =");
//double b = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("C =");
//double c = Convert.ToDouble(Console.ReadLine());
//string x1 = Convert.ToString((-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
//string x2 = Convert.ToString((-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
//Console.WriteLine("x1 = " + x1);
//Console.WriteLine("x2 = " + x2);


// 9th lesson
// 1
//Console.WriteLine("Enter number");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine((0 < num && num < 10 || 20 < num && num < 30 || 40 < num && num < 50) ? true : false);
// 2
//Console.WriteLine("A =");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("B =");
//double b = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("C =");
//double c = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine(((a + b) > c && (a + c) > b && (b + c) > a) ? true : false);
// 3
//Console.WriteLine("A =");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("B =");
//double b = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("C =");
//double c = Convert.ToDouble(Console.ReadLine());
//double x, y, big;
//if (a > b && a > c)
//{
//    x = b;
//    y = c;
//    big = a;
//}
//else if (b > a && b > c)
//{
//    x = a;
//    y = c;
//    big = b;
//}
//else
//{
//    x = a;
//    y = b;
//    big = c;
//}
//if (x > y) Console.WriteLine(big + " " + x + " " + y);
//else Console.WriteLine(big + " " + y + " " + x);


// 10th lesson
//Console.WriteLine("Enter two-digit number");
//string res = "";
//int number = Convert.ToInt32(Console.ReadLine());
//string num_str = "";
//if (number < 20)
//    switch (number)
//    {
//        case 10:
//            num_str = "десять";
//            break;
//        case 11:
//            num_str = "одинадцать";
//            break;
//        case 12:
//            num_str = "двенадцать";
//            break;
//        case 13:
//            num_str = "тринадцать";
//            break;
//        case 14:
//            num_str = "четырнадцать";
//            break;
//        case 15:
//            num_str = "пятнадцать";
//            break;
//        case 16:
//            num_str = "шестнадцать";
//            break;
//        case 17:
//            num_str = "семнадцать";
//            break;
//        case 18:
//            num_str = "восемнадцать";
//            break;
//        case 19:
//            num_str = "девятнадцать";
//            break;
//    }
//else
//    switch (number % 10)
//    {
//        case 1:
//            num_str = "один";
//            break;
//        case 2:
//            num_str = "два";
//            break;
//        case 3:
//            num_str = "три";
//            break;
//        case 4:
//            num_str = "четыре";
//            break;
//        case 5:
//            num_str = "пять";
//            break;
//        case 6:
//            num_str = "шесть";
//            break;
//        case 7:
//            num_str = "семь";
//            break;
//        case 8:
//            num_str = "восемь";
//            break;
//        case 9:
//            num_str = "девять";
//            break;

//    }
//string dec_str = "";
//int dec = number / 10;
//switch (dec)
//{
//    case 2:
//        dec_str = "Двадцать";
//        break;
//    case 3:
//        dec_str = "Тридцать";
//        break;
//    case 4:
//        dec_str = "Сорок";
//        break;
//    case 5:
//        dec_str = "Пятьдесят";
//        break;
//    case 6:
//        dec_str = "Шестьдесят";
//        break;
//    case 7:
//        dec_str = "Семьдесят";
//        break;
//    case 8:
//        dec_str = "Восемьдесят";
//        break;
//    case 9:
//        dec_str = "Девяносто";
//        break;
//}
//Console.WriteLine(dec_str + " " + num_str);


// 11th lesson
// 1
//Console.WriteLine("Enter A =");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter B =");
//int b = Convert.ToInt32(Console.ReadLine());
//int res;
//if (b == 0)
//    res = 1;
//else
//{
//    res = a;
//        for (int i = 2; i <= b; i++)
//        {
//            res *= a;
//        }
//}    
//Console.WriteLine(res);

// 2
//Console.WriteLine("Enter A =");
//int a = Convert.ToInt32(Console.ReadLine());
//for (int i = a; i <= 1000; i+=a)
//    Console.WriteLine(i);

// 3
//Console.WriteLine("Enter A =");
//int a = Convert.ToInt32(Console.ReadLine());
//int res = 0;
//for (int i = 0; i * i < a; i++)
//    res++;
//Console.WriteLine(res);

// 4
//Console.WriteLine("Enter A =");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter B =");
//int b = Convert.ToInt32(Console.ReadLine());
//int start;
//if (a % 7 == 0) start = a;
//else start = a / 7 * 7 + 7;
//int sum = 0;
//for (int i = start; i <= b; i += 7) sum += i;
//Console.WriteLine(sum);

// 5
//Console.WriteLine("Enter number");
//int num = Convert.ToInt32(Console.ReadLine());
//int a = 1;
//int b = 1;
//int c;
//if (num < 3) Console.WriteLine(b);
//else
//{
//    for (int i = 3; i <= num; i++)
//        {
//        c = a;
//        a = b;
//        b = a + c;
//        }
//    Console.WriteLine(b);
//}


// 12th lesson
// 1
//Console.WriteLine("Enter A =");
//int a = Convert.ToInt32(Console.ReadLine());
//int div = a;
//while (div > 0)
//{
//    div--;
//    if (a % div == 0)
//    {
//        Console.WriteLine(div);
//        div = 0;
//    }

//}

// 2
//Console.WriteLine("Enter A =");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter B =");
//int b = Convert.ToInt32(Console.ReadLine());
//int c;
//if (a < b)
//{
//    c = a;
//    a = b;
//    b = c;
//}
//while (b != 0)
//{
//    c = b;
//    b = a % b;
//    a = c;
//}
//Console.WriteLine(a);

// 3
//Console.WriteLine("Enter number:");
//int num = Convert.ToInt32(Console.ReadLine());
//int count = 0;
//while (num != 0)
//{
//    int tmp = num % 10;
//    if (tmp % 2 ==0) count++;
//    num /= 10;
//}
//Console.WriteLine(count);

// 4
//Console.WriteLine("Enter number:");
//int num = Convert.ToInt32(Console.ReadLine());
//string res = "";
//while (num != 0)
//{
//    res += Convert.ToString(num % 10);
//    num = num / 10;
//}
//Console.WriteLine(res);

// 5
//Console.WriteLine("Enter number:");
//int num = Convert.ToInt32(Console.ReadLine());
//int a = 0;
//int b = num;
//int mid = (b + a) / 2;
//while (mid * mid * mid != num)
//{
//    if (mid * mid * mid > num) b = mid;
//    else a = mid; 
//    mid = (b + a) / 2;
//}
//Console.WriteLine(mid);


// 13th lesson
// 1
//string pass = "";
//do
//{
//    Console.WriteLine("Enter password");
//    pass = Console.ReadLine();
//}
//while (pass != "Pass123!");

// 2
//int num = 0;
//int res = 0;
//do
//{
//    Console.WriteLine("Enter number");
//    num = Convert.ToInt32(Console.ReadLine());
//    if (res < num) res = num;
//}
//while (num != 0);
//Console.WriteLine(res);

// 3
//int num = 0;
//int count = 0;
//do
//{
//    Console.WriteLine("Enter number");
//    num = Convert.ToInt32(Console.ReadLine());
//    if (num != 0 &&(num % 3 == 0 ^ num % 7 == 0 ^ num % 11 == 0)) count++;
//}
//while (num != 0);
//Console.WriteLine(count);

// 4
//int num = 0;
//int pos = 0;
//int neg = 0;
//do
//{
//    Console.WriteLine("Enter number");
//    num = Convert.ToInt32(Console.ReadLine());
//    if (num == 0) ;
//    else if (num > 0) pos += num;
//    else neg += num;
//}
//while (num != 0);
//if (pos > -neg) Console.WriteLine("Сумма положительных больше");
//else if (pos < -neg) Console.WriteLine("Сумма негативных больше");
//else Console.WriteLine("Суммы положительных и негативных равны");


// 14th lesson
// 1
//Console.WriteLine("Enter A =");
//int a = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//for (int i = 1; i <= a; i++)
//{
//    sum += i;
//}
//Console.WriteLine(sum);

// 2
//Console.WriteLine("Enter A =");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter B =");
//int b = Convert.ToInt32(Console.ReadLine());
//int count = 0;
//for (int i = a; i <= b; i++)
//{
//    bool flag = true;
//    for (int j = 2; j < i; j++)
//    {
//        if (i % j == 0)
//        {
//            flag = false;
//        }
//    }
//    if (flag)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);

//3
//Console.WriteLine("Enter A =");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter B =");
//int b = Convert.ToInt32(Console.ReadLine());
//string flag = "НЕТ";
//do
//{
//    int i = a % 10;
//    a /= 10;
//    int tmp = b;
//    do
//    {
//        int j = tmp % 10;
//        tmp /= 10;
//        if (i == j)
//        {
//            flag = "ДА";
//        }
//    }
//    while (tmp > 0);

//}
//while (a > 0);
//Console.WriteLine(flag);


// 15th lesson
using MyFirstProjectC;
// 1
//LinearEquation.SolveEquation();

// 2
//LinearEquation.SolveSumMultDif();

// 3
//LinearEquation.GetStringFromDigit();

// 4
//LinearEquation.CheckNumInFIXRanges();

// 5
//LinearEquation.SolveRangesSum();

// 6
//LinearEquation.GetFibonachiNum();

// 7
//LinearEquation.GetCountOdd();

// 8
//LinearEquation.GetMirrowNumber();

// 9
//LinearEquation.CompareTwoNumbers();

// 17th lesson
// in class ActionsWithArrays

// 18th lesson
//ActionsWithArrays.TestBubbleSort();
//ActionsWithArrays.TestSelectionSort();

// 19th lesson
//TwoDimensionalArrays.TestMinElement();
//TwoDimensionalArrays.TestMethods();


// 24th lesson
using MyFirstProjectC;

Animal animal1 = new Animal();
animal1.Kind = "tiger";
animal1.RequiredBiom = "savana";
animal1.RequiredArea = "20 m^2";
//animal1.TypeFood = { "fish", "meat" };
animal1.PredatorOrHerbivore = "predator";
animal1.Sound = "Rrrrrr";

animal1.Name = "Simba";
animal1.FoodPerDay = 7.5;
animal1.Age = 9;


Console.WriteLine(animal1.Kind);
Console.WriteLine(animal1.RequiredBiom);
Console.WriteLine(animal1.RequiredArea);
Console.WriteLine(animal1.PredatorOrHerbivore);
Console.WriteLine(animal1.Sound);
Console.WriteLine(animal1.Name);
for (int i = 0; i < 5; i++)
{
    animal1.Eat();
    Console.WriteLine($"Всего съедено {animal1.eated}кг.");
}
Console.WriteLine($"Возраст {animal1.Age}");

