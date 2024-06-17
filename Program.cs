// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого 
// чётная.


bool IsTrue(string value)
{
    if(value == "q") 
    {
        return false;
    }
    int num = Convert.ToInt32(value);
    int sum = 0;
    while(num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    if(sum % 2 == 0)
    {
        return false;
    }
    return true;
}


bool work = true;
Console.WriteLine("Input number or 'q': " );
while(work)
{   
    string value = Console.ReadLine();
    if(IsTrue(value))
    {
        System.Console.WriteLine("Next");
    }
    else
    {
        System.Console.WriteLine("STOP");
        work = false;
    }
}


// Задача2
// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateRandomArrayThirdDigit(int size)
// {    
//     int[] array = new int[size];
//     Random random = new Random();
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(100, 999 + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }


// int ArrayCounter(int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// Console.WriteLine("Input size of array: " );
// int size = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArrayThirdDigit(size);
// PrintArray(myArray);
// Console.Write("Количество четных чисел: ");
// Console.WriteLine(ArrayCounter(myArray));

// Задача3
// Реверсирование одномерного массива

// int[] CreateRandomArray(int size, int minRange, int maxRange)
// {    
//     int[] array = new int[size];
//     Random random = new Random();
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(minRange, maxRange + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }
  
// int[] arrayRevers(int[] matrix)
// {
//     int temp;
//     for (int i = 0; i < matrix.Length / 2; i++)
//     {    
//         temp = matrix[i];
//         matrix[i] = matrix[matrix.Length - 1 - i];
//         matrix[matrix.Length - 1 - i] = temp;
//     }
//     return matrix;
// }

// System.Console.WriteLine("Input size of array: " );
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: " );
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(size, min, max);
// Console.Write("Исходный массив: ");
// PrintArray(myArray);
// Console.Write("Перевернутый массив: ");
// PrintArray(arrayRevers(myArray));
