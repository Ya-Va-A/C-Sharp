// 31. Задать массив из 8 элементов и вывести их на экран

// вариант 1 - цикл
// int [] A=new int [8];
// int index=0;
// while (index<8)
// {
//     A [index] = new Random().Next (0, 100);
//    index++; 
// } 
// index=0;
// while (index<8)
// {
//     Console.WriteLine (A [index]);
//     index++;
// }
                  //~~~~~~~~~~~~~~~~~
// вариант 2 - метод
// int [] A=new int [8];
// //метод заполнения массива целыми числами
// int [] Massive (int [] A)

// {
//     for (int index=0; index<A.Length; index++)
//     {
//        A [index] = new Random().Next (0, 100); 
//         Console.WriteLine (A [index]);
//     }
//     return A;
// }

// Massive (A);

//----------------------------------------------------------

// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран


// 31. Задать массив из 8 элементов и ввести их на экран

//char FillArray() // тип данных - символы, на входе еще ничего нет
// {
//     return Convert.ToChar(new Random().Next(100,150));
// }

// char[] array = new char[8];
// массив
// Console.WriteLine("Массив из 8 элементов");
// for (int index = 0; index < array.Length; index++)
// {
//     array[index] = FillArray();
//     Console.Write($"{array[index]}");
// }
// Console.WriteLine();

// method
// string PrintArray(char[] array)
// {
//     string result = string.Empty;
//     for (int index = 0; index < array.Length; index++)
//     {
//         result += $"{Convert.ToChar(new Random().Next(65,90))} ";
//     }
//     return result;
// }

// char[] array = new char[8];

// console.WriteLine("Массив из 8 элементов");
// Console.WriteLine(PrintArray(array));

// string PrintArray(char[] array)
// {   
//     string result = string.Empty;                                  // Создаем пустую строку 
//     for (int index = 0; index < array.Length; index++)
//     {
//         result += $"{Convert.ToChar(new Random().Next(65,90))} ";  // 65-90 это символы A..Z в таблице кодировок
//     }
//     return result;
// }

// char[] array = new char[8];                                         // создаем массив из 8 символов (по умолчанию пустой)

// Console.WriteLine("Массив из 8 элементов");
// Console.WriteLine(PrintArray(array));                               // вызываем функцию и выводим на экран массив символов


//

// 32. Задать массив из 8 элементов и ввести их на экран

// string FillArray(int[] array) // тип данных - символы, на входе еще ничего нет
// {
//     string result = string.Empthy;
//     for (int index = 0; index < array.Length; index++)
//     {
//        array[index] = new Random().Next(0, 2);
//        result += $"{array[index]}";
//     }
//     return result;
// }

// int[] array = new int [8];

// Console.WriteLine("Массив из 8 элементов");
// Console.WriteLine(PrintArray(array));  

//32 Задать м ассив из 12 элементов? заполненных числами [0,9].
// и найти сумму положительных  отрицательных чисел

int Array(int[] array)//[0,1,2,3,4,5,6,7,8,9]
{
    for (int = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(0, 2);
    }
    return array [index];
}

int PrintArray(int[] array)
{
    int index=0;
    for (index < array.Length; index++)
    Console.WriteLine(array[index]);
    return
}

int[]array = new int [12];
PrintArray(array);
Console.WriteLine("Массив из 18 элементов от 0 до 9")ж


// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
// 34. Написать программу замену элементов массива на противоположные
// 35. Определить, присутствует ли в заданном массиве, некоторое число
// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

//------------------------------------------

// 40 В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// double[] mass = new double [10] {10.1, 23.6, 67.6, 0.1, 13.6, 7.6, 10.1, 6.6, 6.61, 0.1};
// double max (double[] Max)
// {
//     double max = mass[0];
//     for (int index = 1; index < mass.Length; index++)
//     if (mass [index] > max) max = mass[index];
//     return max;
// }
// double maximum = max (mass);
// Console.WriteLine($"Maximum {maximum}");

// double min (double[] Min)
// {
//     double min = mass[0];
//     for (int index = 1; index < mass.Length; index++)
//     if (mass [index] < min) min = mass[index];
//     return min;
// }
// double minimum = min (mass);
// Console.WriteLine($"Minimum {minimum}");

// double dif (double maximum, double minimum)
// {
//     return maximum - minimum;
// }
// double Differences = dif(maximum, minimum);
// Console.WriteLine ($"Differences between max and min {Differences}");


