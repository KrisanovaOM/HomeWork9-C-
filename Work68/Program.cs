// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int GetInputNumberFromConsole(string text)
{
  Console.WriteLine($"Введите целое число {text}: ");
  return Convert.ToInt32(Console.ReadLine());
}

int GetResultAkkermanFunction(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return GetResultAkkermanFunction(m - 1, 1);
  else return GetResultAkkermanFunction(m - 1, GetResultAkkermanFunction(m, n - 1));
}

//Начало основной программы
int m = GetInputNumberFromConsole("m");
int n = GetInputNumberFromConsole("n");

Console.Write($"m = {m}; n = {n} -> {GetResultAkkermanFunction(m, n)}");

