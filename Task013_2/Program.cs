// выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine( ));
if (number < 100)
Console.WriteLine("Третьей цифры нет");
string str_number = number.ToString();
char digit3 = str_number[2];
string new_str_number = digit3.ToString();
int new_number = Convert.ToInt32(new_str_number);
Console.WriteLine($"Третья цифра числа:{new_number}");
    