// Проверить, что натуральное число m
// нат числа - 1, 2, 3, 4, 5, 6, 7, 8, 9

// 1. является счастливым пятизначным

// int HappyNumber = 55555;
// int m = new Random().Next (50000, 60000);
// Console.WriteLine ($"Является ли {m} счастливым числом");
// if (m == HappyNumber) Console.WriteLine ("да, является");
// else 
// Console.WriteLine("нет");

// 2. образовано тремя цифрами, составляющими арифметическую прогрессию

//задаем первый элемент = 2
// формула ар прогресси a{i} = a1+(i-1)d, где d - разность прогрессии
// обозначим разность (шаг) прогресси d = 3
// выводим на конcоль в ряд три числа прогрессии



// int start = 2;
// int d = 4;
// int index = 0;
// int Sn (int a) // Sn - обозначение арифметической прогрессии
// {
//     int result = start + d;
//     return result;

// }
// Console.WriteLine(index);

int Factorial(int n)
{
    if (n == 1) return 1;
 
    return n * Factorial(n - 1);
}
 
int factorial4 = Factorial(4);  // 24
int factorial5 = Factorial(5);  // 120
int factorial6 = Factorial(6);  // 720
 
Console.WriteLine($"Факториал числа 4 = {factorial4}");
Console.WriteLine($"Факториал числа 5 = {factorial5}");
Console.WriteLine($"Факториал числа 6 = {factorial6}");

// int n = 0;
// while (index <= 3)
// {
//     if (index - start == d)
//         {
//             Console.WriteLine(n);
//         }
//     index++;
// }



// 3. образовано четырмя одинаковыми цифрами