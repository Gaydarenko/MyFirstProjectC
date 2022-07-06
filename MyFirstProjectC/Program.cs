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
Console.WriteLine("A =");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("B =");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("C =");
double c = Convert.ToDouble(Console.ReadLine());
string x1 = Convert.ToString((-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
string x2 = Convert.ToString((-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
Console.WriteLine("x1 = " + x1);
Console.WriteLine("x2 = " + x2);