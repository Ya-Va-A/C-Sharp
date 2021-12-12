// 0. Вывести квадрат числа
// int number = 3;
// int result = number * number; 
// Console.WriteLine(result);

// ------------------------------

// 1.По двум заданным числам 
// проверять является ли первое квадратом второго
// int numberA = 3
// int numberB = 9
// if ()

// ------------------------------

// 2. Даны два числа. Показать большее и меньшее число
//  int a = 3;
//  int b = 9;
//  int max = a;
//  int min = b;

//  if (a > max) max = a; 
//  if (b < max) min =b;
//  if (b > max) max = b;
//  if (a < max) min = a;

// Console.Write("max = ");
// Console.WriteLine(max);
// Console.Write("min = ");
// Console.WriteLine(min);

// ------------------------------

// 3.По заданному номеру дня недели вывести его название

// Console.WriteLine ("Enter day number");
// string daynumber = Console.ReadLine();
// if (daynumber.ToLower() == "1")
// {
//     Console.WriteLine("Monday");
// }
// if (daynumber.ToLower() == "2")
// {
//     Console.WriteLine("Tuesday");
// }
// if (daynumber.ToLower() == "3")
// {
//     Console.WriteLine("Wednesday");
// }
// if (daynumber.ToLower() == "4")
// {
//     Console.WriteLine("Thursday");
// }
// if (daynumber.ToLower() == "5")
// {
//     Console.WriteLine("Friday");
// }
// if (daynumber.ToLower() == "6")
// {
//     Console.WriteLine("Suterday");
// }
// if (daynumber.ToLower() == "7")
// {
//     Console.WriteLine("Sunday");
// }

// Var 1
// Console.WriteLine("Enter number from 1 to 7");
//   string DayName (int daynumber)
// {
//        string[] dayname = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
//        return dayname[daynumber - 1];
// } 
// int daynumber = new Random().Next(1,8);
// Console.WriteLine($"{daynumber} = {DayName(daynumber)}");

// ------------------------------

// 4. Найти максимальное из трех чисел

// int a = 5;
// int b = 9;
// int c = 2;
// int max = a;
// if (a > max) max = a;
// if (b > max) max = b;
// if (c > max) max = c;

// Console.WriteLine("max = ");
// Console.WriteLine (max);

// 5. Написать программу вычисления значения функции y = f(a)
// Console.WriteLine ("Enter number");
// int a = new Random().Next (1, 10);
// int y = a;
// Console.WriteLine ($"y=f({a})");

// ------------------------------

// 6. Выяснить является ли число чётным

// int a = new Random().Next (1,10);
// bool NUM (int a)
// {
//     if (a % 2 == 0) return true;
//     else return false;
// }
// Console.WriteLine($"Проверяемое число {a}");
// if (NUM (a) == true)
// Console.WriteLine ($"{a} - число четное");
// if (NUM (a) == false)
// Console.WriteLine ($"{a} - число нечетное");

// ------------------------------

// 7. Показать числа от -N до N

// int start = -1;
// int end = 1;
// int count = 0;

// while (end <= start)
// {
//     Console.WriteLine(count);
//     start++;
// // }


// int start = -2;
// int end = 2;
// int count = 0;

// while (end<=start)
// {
//      Console.WriteLine(count);
//      count++;
// }

// int result = count; 

// Console.WriteLine(result);




// int count = 1;
// while (count <= 10)
// {
//     Console.WriteLine(count);
//     count++;
// // }


// ------------------------------

// // 8. Показать четные числа от 1 до N

// Console.WriteLine("Введите натуральное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num <= 0)
// {
//     Console.WriteLine("это не натуральное число.");
//     return;
// }
// Console.WriteLine();

// for (int i = 1; i <= num; i++)
// {
//     if (i % 2 == 0)
//     {
//         Console.WriteLine($"{i}");
//     }
// }

// ------------------------------

// 9. Показать последнюю цифру трёхзначного числа

// int N = 123;
// int number = N % 10;
// Console.WriteLine($" Последняя цифра трехзначнго числа - {number}");

// int number = N / 100 % 10; // сотни
//       // int number = N % 10; // единицы
//       //if (N < 100) Console.WriteLine("No 3rd symbol");
// Console.WriteLine($"Ответ {number}");

// ------------------------------

// 10. Показать вторую цифру трёхзначного числа

// int N = 123;
// int number = N/10 %10; //десятки
// Console.WriteLine($" Вторая цифра трехзначнго числа - {number}");

// ------------------------------

// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int num = 40;
int max (int n)
{
    int result = 0;
    if (n % 10 > (n % 100) / 10) result = n % 10;
    if (n % 10 < (n % 100) / 10) result = (n % 100) / 10;
    return result;
}
Console.WriteLine(max(num));

// ------------------------------

// 12. Удалить вторую цифру трёхзначного числа

// int N = 134;
// int Number1 = N/100 % 10;
// int Number3 = N%10;
// Console.WriteLine($"{Number1}{Number3}");

// ------------------------------

// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// int[] a = new Random().Next (1, 15);
// int[] b = new Random().Next (1, 15);
// bool number (B)
// {
//     if (a % b == 0) return true;
//     else return false;

// }
// if (number = true);
// Console.WriteLine ("Кратно");
// if (number = false);
// Console.WriteLine ("Некратно");

// ------------------------------

// 14. Найти третью цифру числа или сообщить, что её нет
// деление на 10, берем остаток
//Console.WriteLine("Введите число");

// int N = 158;
// int number = N / 100 % 10; // сотни
//       // int number = N % 10; // единицы
//       //if (N < 100) Console.WriteLine("No 3rd symbol");
// Console.WriteLine($"Ответ {number}");

//         //проверка метода 
// System.Console.WriteLine (TestNumDec(N, 1)); // единицы передали в метод 

// bool TestNumDec (int number, int n) // int n = 1
// {
//     bool result = false;
//     if (N/100%10 == n) result = true;
//     return result;
// }