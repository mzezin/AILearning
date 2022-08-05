// задача 2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 ->  Пятница
Console.WriteLine("Введите номер дня недели:");
int number = int.Parse(Console.ReadLine());

//первый вариант
if (number > 7)
{
    Console.WriteLine("Введен неправильный номер дня недели");
}
if (number < 1)
{
    Console.WriteLine("Введен неправильный номер дня недели");
}
if (number == 1)
{
    Console.WriteLine("Понедельник");
}
if (number == 2)
{
    Console.WriteLine("Вторник");
}
if (number == 3)
{
    Console.WriteLine("Среда");
}
if (number == 4)
{
    Console.WriteLine("Четверг");
}
if (number == 5)
{
    Console.WriteLine("Пятница");
}
if (number == 6)
{
    Console.WriteLine("Суббота");
}
if (number == 7)
{
    Console.WriteLine("Воскресение");
}

//второй вариант
string[] weekdays = { "пн", "вт", "ср", "чт", "пт", "сб", "вс" };
if (number < 1 || number > 7)
{
    Console.WriteLine("Введен неправильный номер дня недели");
}
else
{
    Console.WriteLine(weekdays[number - 1]);
}

//третий вариант
switch (number)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Wrong weekday");
        break;
}
