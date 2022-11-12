//Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. 
void Even_numbers(int N)
{
    if (N%2==0)
    {
        Console.Write(" " + N +" ");
    }
    if (N>1)
    {
        Even_numbers(N-1);
    }
}
Even_numbers(Convert.ToInt32(Console.ReadLine()));