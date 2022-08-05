// задача про собаку и друзей ббббббяяб  
// входные данные
int dogSpeed = 5;
int friendASpeed = 3;
int friendBSpeed = 2;
int distance = 20;
// внутренние переменные
int count = 0;
bool isFriendA = true;
int time = 0;
while (distance > dogSpeed)
{
  time = isFriendA ?  time = distance/ (dogSpeed + friendBSpeed) : time = distance/ (dogSpeed + friendASpeed);
  isFriendA = !isFriendA;
  distance = distance - (friendASpeed + friendBSpeed) * time;
  count++;
  Console.WriteLine($"time:{time} count:{count} distance:{distance}");
}
Console.WriteLine($"Собака пробежит {count} раз!");
