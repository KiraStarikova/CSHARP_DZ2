// на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int digit1 = num / 10;
int result = digit1 % 10;
Console.Write($"Вторая цифра числа {result}");