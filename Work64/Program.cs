// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


double GetInputNumberFromConsole(string text)
{
  Console.WriteLine($"Введите число {text}: ");
  return Convert.ToDouble(Console.ReadLine());
}

void WriteNumbersRecursionExwmple1(double startNumber, double startNumberAdd1)
{ 
  if (startNumber > 1)  
    WriteNumbersRecursionExwmple1(startNumber - 1, startNumberAdd1);
  if (startNumberAdd1 - startNumber <= startNumberAdd1 - 1)
    Console.Write($"{startNumberAdd1 - startNumber}{(startNumberAdd1 - startNumber == 1 ? "" : ", ")}");  
}

void WriteNumbersRecursionExample2(double n, int count)
{
  if (count > n) 
    return;
  WriteNumbersRecursionExample2(n, count + 1);
  if (count > 1)
    Console.Write(count + ", ");
  else
    Console.Write(count);
}

//Начало основной программы
double N = GetInputNumberFromConsole("N");
//Первый вариант решения
Console.WriteLine("Первый вариант решения: ");
double NAdd1 = N + 1;
Console.Write("N = " + N + " -> ");
WriteNumbersRecursionExwmple1(N, NAdd1);
Console.WriteLine();
// Второй вариант рашения
Console.WriteLine("Второй вариант решения: ");
//double N = GetInputNumberFromConsole("N");
int stopNumber = 1;
Console.Write("N = " + N + " -> ");
WriteNumbersRecursionExample2(N, stopNumber);