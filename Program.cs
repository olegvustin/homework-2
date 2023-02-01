// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Перейдем к задаче 10");
System.Console.Write("Введите трехзначное число: ");

int numABC = Convert.ToInt32(Console.ReadLine());
int numB = 0;

if (numABC > 99 && numABC < 1000)
{
 numB = numABC % 100;
 numB = numB / 10;
 System.Console.WriteLine($"Искомое число: {numB}");
}
else
{
System.Console.WriteLine("Это не трехзначное число, повторите попытку");
}
  

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Перейдем к задаче 13");
System.Console.Write("Введите число: ");
int Value;

if (!int.TryParse(Console.ReadLine(), out Value))
{
    System.Console.WriteLine("Вы ввели не числовое значение!");
    return;
}

int ValueAbs = Math.Abs(Value);   // Для проверки отрицательных

if (ValueAbs < 100)
{
    System.Console.WriteLine("Третьей цифры нет.");
    return;
}

while (ValueAbs > 999)
{
    if (ValueAbs > 999)
    ValueAbs /= 10;
}

System.Console.WriteLine($"Третья цифра в числе - {ValueAbs % 10}");

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Задача № 15");
System.Console.Write("Введите номер дня недели и узнайте какой это день. Выходной или нет?");
int DayOfWeek;
if (! int.TryParse(Console.ReadLine(), out DayOfWeek))
{
  System.Console.WriteLine("Вы ввели не числовое значение!");
  return;
}

switch (DayOfWeek)
{
    case 1:
    case 2:
    case 3:
    case 4:                                                              
    case 5:
    System.Console.WriteLine("Сегодня трудимся. Рабочий день.");
    break;
    case 6:
    case 7:
    System.Console.WriteLine("Сегодня ВЫХОДНОЙ!!!");
    break;
    default:
    System.Console.WriteLine("В неделе всего 7 дней, пробуй еще раз");
    break;
    }