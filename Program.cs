// Задача 64: Выполнить с помощью рекурсии.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(PrintNumbers(N, 1));

// string PrintNumbers(int end, int start){
//     if(end==start) return start.ToString();
//     return (end + " " + PrintNumbers(end - 1, start));
// }

//Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Console.Write("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int sum(int m, int n)
// {
// if (m==n)
// return n;
// else return m + sum(m + 1, n);
// }
// Console.Write($"Сумма натуральных элементов в промежутке от M до N равно {sum(m,n)}");

//Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int funk(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return funk(m - 1, 1);
else return funk(m - 1, funk(m, n - 1));
}

Console.Write($"Функция равна {funk(m, n)}");
