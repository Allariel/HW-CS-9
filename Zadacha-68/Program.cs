//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
static uint Ackerman(uint n, uint m)
{
  if (n == 0)
  {
    return m + 1;
  }
  else
  {
    if ((n != 0) && (m == 0)) return Ackerman(n - 1, 1);
    else return Ackerman(n - 1, Ackerman(n, m - 1));
  }
}
uint res;
res = Ackerman(3, 2); // res = 4
Console.WriteLine(res);
