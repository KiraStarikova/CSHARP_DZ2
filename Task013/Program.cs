// выводит третью цифру заданного числа или сообщает, что третьей цифры нет

int num = new Random().Next(10, 100000);
Console.WriteLine(num);
int num1 = num / 100;
int result = num1 % 10;
if (result > 0)
    Console.WriteLine($"Третья цифра {result}");
else
    Console.WriteLine("Третьей цифры нет");