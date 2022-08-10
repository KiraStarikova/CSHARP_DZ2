//принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру дня недели от 1 до 7 ");
int number = Convert.ToInt32(Console.ReadLine( ));
if (number > 0 && number < 6)
    Console.Write("нет");
if (number == 6 || number == 7)
    Console.Write("да");