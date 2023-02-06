﻿// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая 
// покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Задача 4: Дан список некоторых целых чисел, найдите значение 20 в нем и, если оно присутствует, замените его на 200. 
// Обновите список только при первом вхождении числа 20. (можно использовать List<integer> )
// [21, 53,20, 56, 45,20] -> [21, 53,200, 56, 45,20]

// Задача 5: Кегли N кеглей выставили в один ряд, занумеровав их слева направо числами от 1 до N. 
// Затем по этому ряду бросили K шаров, при этом i-й шар сбил все кегли с номерами от li до ri включительно. 
// Определите, какие кегли остались стоять на месте.
// Программа получает на вход количество кеглей N и количество бросков K. Далее идет K пар чисел li, ri, при этом 1≤ li≤ ri≤ N.
// Программа должна вывести последовательность из N символов, где j-й символ есть “I”, если j-я кегля осталась стоять, или “.”, если j-я кегля была сбита.

int Proverca_chisla()
{ 
  int num;
  while (true)
    {var input = Console.ReadLine();

    if (int.TryParse(input, out num))
        break;                                                   // обработка при успехе и выход из цикла
    else                                                         // обработка при ошибке
    {
        Console.WriteLine("[ERROR]: Некоректные данные по пробуйте еще раз!");
        Console.Write("Введите число: ");
    }
    }
  return num;
}

//Функция для заполнения массива рандомом
int[] R_Mas()
{
  Console.Write("Введите размер массива: ");
  int n = Proverca_chisla();
  int[] f  = new int [n];
  Console.Write("Введите минимальное значения рандома для массива: ");
  int min = Proverca_chisla();
  Console.Write("Введите максимальное значения рандома для массива: ");
  int max = Proverca_chisla();

  int j=0;
  while (j < f.Length)
      {
        f[j]= new Random().Next(min,max);
        j++;        
      }
  return f;
}

// Функция вывода
void PrintMas(int[] arr){
    for(int j=0;j<arr.Length;j++)
        {
            System.Console.WriteLine($"Вывод {j} элемента: {arr[j]}");
        }
    System.Console.WriteLine();
}

int otvet1 = 0;
string? otvet2 = " ";
do
{
  do
  { 
    Console.Clear();

    Console.WriteLine("Добрый день прошу выбрать цифру из списка что Вы хотите сделать?");
    Console.WriteLine("__________");
    Console.WriteLine("1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,");
    Console.WriteLine("которая покажет количество чётных чисел в массиве.");
    Console.WriteLine("2. Задайте одномерный массив, заполненный случайными числами. ");
    Console.WriteLine("Найдите сумму элементов, стоящих на нечётных позициях.");
    Console.WriteLine("3. Задайте массив вещественных чисел. Найдите разницу между");
    Console.WriteLine("максимальным и минимальным элементов массива.");
    Console.WriteLine("4. Дан список некоторых целых чисел, найдите значение 20 в нем и, если оно присутствует, замените");
    Console.WriteLine("его на 200. Обновите список только при первом вхождении числа 20. (можно использовать List<integer> )");
    Console.WriteLine("5. Кегли N кеглей выставили в один ряд, занумеровав их слева направо числами от 1 до N.");
    Console.WriteLine("Затем по этому ряду бросили K шаров, при этом i-й шар сбил все кегли с номерами от li до ri включительно.");
    Console.WriteLine("Определите, какие кегли остались стоять на месте.");
    Console.WriteLine(" ");
    Console.Write("Ваш ответ: ");

    otvet1 = Proverca_chisla();

    if (otvet1 > 14 ^ otvet1 < 1)
    {
      Console.WriteLine("Такой задачи тут нету!");
      Console.Write("Нажмите <Enter> для повторго ввода... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}      
    }

  } while (otvet1 > 14 ^ otvet1 < 1);

  Console.Clear();

//Начало тела задач

// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая 
// покажет количество чётных чисел в массиве.

  if (otvet1 == 1)
    {
      int [] arra1;
      arra1 = R_Mas();
      System.Console.WriteLine("Начальный массив:");
      PrintMas(arra1);
      
      int count=0;
      for (int i1=0;i1<arra1.Length;i1++)
      {
        if (arra1[i1] % 2 == 0) {count++;};
      }

      System.Console.WriteLine($"Четных числе в массиве: {count}");      
    }



//Конец тела задач    
  Console.Write("Нажмите <Enter> для продолжения... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}

  do
  {
    Console.Clear();
    Console.WriteLine("Вы хотите воспользоваться еще одним решением? Yes/No");
    Console.WriteLine(" ");
    otvet2 = Console.ReadLine();

    if (otvet2 != "No" && otvet2 != "no" && otvet2 != "NO" && otvet2 !="n" && otvet2 !="N" 
        && otvet2 != "Yes" && otvet2 != "yes" && otvet2 != "YES" && otvet2 !="y" && otvet2 !="Y")
    {
    Console.WriteLine("Некоректный ответ");
    Console.Write(" Нажмите <Enter> для повторго ввода... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}
    }
  }
  while (otvet2 != "No" && otvet2 != "no" & otvet2 != "NO" && otvet2 !="n" && otvet2 !="N" 
        && otvet2 != "Yes" && otvet2 != "yes" && otvet2 != "YES" && otvet2 !="y" && otvet2 !="Y");

}
while (otvet2 != "No" & otvet2 != "no" & otvet2 != "NO" & otvet2 !="n" & otvet2 !="N");

Console.Clear();

Console.WriteLine("Спасибо, что воспользовались программой. Досвидание!!!");
Console.Write("Нажмите <Enter> для выхода... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}

Console.Clear();
