//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
void Sum(int m, int n,int sum)
{
   if (m==n)
   {
     Console.Write("Sum="+(sum+n));
   }
   else
   {
     sum+=m++;
     Sum(m,n,sum);
   }
}
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Sum(Math.Min(m,n),Math.Max(m,n),0);




