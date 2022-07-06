Console.WriteLine("Как Вас зовут?");
string firstName = Console.ReadLine();
string hello = "Привет, " + firstName + "!!!";
Console.WriteLine(hello);

Console.WriteLine("Какая у Вас фамилия?");
string lastName = Console.ReadLine();
Console.WriteLine("А какое у Вас отчество?");
string middleName = Console.ReadLine();
string fullName = lastName + " " + firstName + " " + middleName;
Console.WriteLine(fullName);
