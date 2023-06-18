// ДЗ
// Задача 47. Задайте двумерный масси размером m*n, заполненный случайными вещественными числами.
// Пример:
// m = 3, n = 4
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] resMatrix = GetMatrix(rows, columns);

// PrintMatrix(resMatrix); 

// double[,] GetMatrix(int m, int n)
// {
//     double[,] matrix = new double[m,n]; 
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) 
//         {
        
//               matrix[i,j] = rnd.NextDouble() * 10;
            
//         }
//     }
//     return matrix;

// }
// void PrintMatrix(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(Math.Round(array[i,j],2) + "\t"); 
//         }
//         Console.WriteLine();
//     }
// }


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите элемент: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int[,] resMatrix = GetMatrix(rows, columns);

// PrintMatrix(resMatrix); 
// Console.WriteLine();
// // Element(numberForSearch);
// // Element(number);

// int[,] GetMatrix(int m, int n)
// {
//     int[,] matrix = new int[m,n]; 
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) 
//         {
        
//               matrix[i,j] = i + j;
            
//         }
//     }
//     return matrix;

// }
// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + "\t"); 
//         }
//         Console.WriteLine();
//     }
// }
           

// bool Element (int[,] array, int numberForSearch)

// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         if (array[i,j] == numberForSearch)
//         {
//             return true; // true - элемент найден
//         }
        
//     }
//     return false; //false - элемент не найден
// }

// int numberForSearch = new Random().Next(11); 
// if (Element(numberForSearch)) //FindElement(array, numberForSearch) == true
// {
//     Console.WriteLine($"Число {numberForSearch} в массиве присутствует");
// }
// else //FindElement(array,numberForSearch) == false
// {
//     Console.WriteLine($"Число {numberForSearch} в массиве отсутствует");
// }






// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] resMatrix = GetMatrix(rows, columns);

// Console.WriteLine();
// PrintMatrix(resMatrix);
// ArithmeticMean(resMatrix); 


// int[,] GetMatrix(int m, int n)
// {
//     int[,] matrix = new int[m,n]; 
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) 
//         {

//               matrix[i,j] = i + j;

//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + "\t"); 
//         }
//         Console.WriteLine();
//     }
// }

// void ArithmeticMean(int[,] matrix)
// {

//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         double sum = 0;
//         for (int j = 0; j < matrix.GetLength(0); j++)
//         {
//             sum = sum + matrix[j,i];
//         }
//         Console.WriteLine($"Среднее арифметическое {i + 1} столбца = {sum / matrix.GetLength(0)}");
//     }
// }


// Дополнительное:
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12



// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] resMatrix = GetMatrix(rows, columns);

// Console.WriteLine();
// PrintMatrix(resMatrix);
// ElementSum(resMatrix); 


// int[,] GetMatrix(int m, int n)
// {
//     int[,] matrix = new int[m,n]; 
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) 
//         {

//               matrix[i,j] = i + j;

//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + "\t"); 
//         }
//         Console.WriteLine();
//     }
// }
// void ElementSum(int[,] array)

// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//        for (int j = 0 ; j < array.GetLength(1); j++)
//        {
//          if( i == j) 
//         {
//             sum += array[i,j]; 
//         }
//        }
//     }
//     Console.WriteLine($"Сумма элементов по диагонали равна: {sum}");
// }