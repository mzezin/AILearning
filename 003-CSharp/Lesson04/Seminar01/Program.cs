// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// 7 -> 28
// 4 -> 10
// 8 -> 36

// А потом выдаёт произведение чисел от 1 до А.
// 4  -> 24
// 5  -> 120

int mySigma ( int number) {
  int result = 0;
  for (int i = 1; i <= number; i++)
  {
    result += i;
  }
  return result;
}

int myFactorial ( int number) {
  int result = 1;
  for (int i = 1; i <= number; i++)
  {
    result *= i;
  }
  return result;
}

int number = int.Parse(Console.ReadLine());

Console.WriteLine(mySigma(number));

Console.WriteLine(myFactorial(number));

// Console.WriteLine(mySigma(7));
// Console.WriteLine(mySigma(4));
// Console.WriteLine(mySigma(8));

// Console.WriteLine(myFactorial(4));
// Console.WriteLine(myFactorial(5));


