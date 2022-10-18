// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

double GetInputNumberFromConsole(string text)
{
  Console.WriteLine($"Введите число {text}: ");
  return Convert.ToDouble(Console.ReadLine());
}
//Метод проверяющий, что одно число меньше другого
bool IsFirstDigitLessSecondDigit(double firstNumber, double secondNumber) 
{
  if (firstNumber < secondNumber) return true;
  return false;
} 

void GetSumNaturalElements(double m, double n, double sum)
{
  if (n%1 != 0 || m%1 != 0)
  {
    if (m%1 != 0)
      m = Math.Truncate(m) + 1;
    n = Math.Truncate(n);
  }

  sum += n;

  if (n <= m)
  {
    Console.Write($"{sum} ");
    return;
  }

  GetSumNaturalElements(m, n - 1, sum);
  
}

//Начало основной программы
double M = GetInputNumberFromConsole("M");
double N = GetInputNumberFromConsole("N");

if (IsFirstDigitLessSecondDigit(N, M))
{
  Console.WriteLine("Меняем местами числа M и N, так как M должно быть всегда меньше N");
  double tempMN = M;
  M = N;
  N = tempMN;
}

Console.Write($"M = {M}; N = {N} -> ");
double sum = 0;
GetSumNaturalElements(M, N, sum);
Console.WriteLine();
