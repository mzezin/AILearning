//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double myPow( double a, int b) {
  double result = 1;
  for (int i = 1; i <= b; i++)
  {
    result = result * a;
  }
  return result;
}

Console.WriteLine(myPow(3, 5));
Console.WriteLine(myPow(2, 4));