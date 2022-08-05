// если введено положительное число, то возводим в квадрат
//#pragma warning disable CS8604 
Console.WriteLine("Введите положительное число: ");
int number = int.Parse(Console.ReadLine()); // int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    Console.WriteLine("Число, возведенное в квадрат: " + number * number);
}
if (number < 0){
    Console.WriteLine("Число отрицательное");
}
if (number == 0){
    Console.WriteLine("Введен 0");
}
