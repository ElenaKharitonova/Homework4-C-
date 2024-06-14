// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого 
// чётная.

//*Задайте одномерный массив из 10 целых чисел от 1 до 100. 
//*Найдите количество элементов массива, значения которых лежат в отрезке [10,90].

// static int CountItemsRange(int[] numbers, int minRange, int maxRange)
//     {      
//       int count = 0;
//       for(int i = 0; i < numbers.Length; i++)
//       {
//          if (numbers[i] <= maxRange && numbers[i] >= minRange)
//          {
//              count += 1;
//          }
//       }
//        return count;
//     }
// int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
// Console.WriteLine(CountItemsRange(array, 10, 90));

// Задача2
// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// static int CountEvenItems(int[] numbers)
//     {
//       int count = 0;
//       for(int i = 0; i < numbers.Length; i++)
//       {
//          if (numbers[i] % 2 == 0)
//          {
//              count += 1;
//          }
//       }
//        return count;  
//     }

// int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4};
// Console.WriteLine(CountEvenItems(array));

//Задача 3
// Напишите программу, которая перевернёт одномерный массив (первый элемент 
// станет последним, второй – предпоследним и т.д.)

static double FindMin(double[] numbers)
    {
      double min = 100000;
      for(int i = 0; i < numbers.Length; i++)
      {
         if (numbers[i] < min)
         {
             min = numbers[i];
         }
      }
       return min;    
            
    }
    
   
    static double FindMax(double[] numbers)
    {
      double max = 0;
      for(int i = 0; i < numbers.Length; i++)
      {
         if (numbers[i] > max)
         {
             max = numbers[i];
         }
      }
       return max;    
      
    }
    
double[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01};
Console.WriteLine(FindMax(array) - FindMin(array));
