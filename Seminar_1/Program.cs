// int a = 123, b = 321;
// // Console.WriteLine("a: ");
// // Console.WriteLine(a);
// // Console.WriteLine("b: ");
// // Console.WriteLine(b);

// Console.WriteLine($"a: {a} b: {b}"); // интерполяция строк
// Console.WriteLine("a:{0} b: {1}", a, b); // конкатинация строк
// Console.WriteLine($"a: " + a + "b: " + b);



// поменять значение переменных местами
// int a = 12, b = 43;
// int c;
// c = b;
// b = a;
// a = c;
// Console.WriteLine($"a: {a} b: {b}");

// усложним задача - поменять местами без доп. переменной
// int a = 12, b = 43;
// a = a + b;
// b = a - b;
// a = a - b;
// Console.WriteLine($"a: {a} b: {b}");

// уасложним за счет больших разрядов

// int a = 2_000_000_000, b = 1_000_000_000;
// Console.WriteLine($"a: {a}");
// a = a + b;
// Console.WriteLine($"a: {a}");
// b = a - b;
// a = a - b;
// Console.WriteLine($"a: {a} b: {b}");

//оператор условновного ветвления

//int a = 43, b = 65;
// if (a > b) //условие
// {
//     Console.WriteLine(a); //если условие истина
// }
// else // иначе
// {
//     Console.WriteLine(b); //если условие ложь
// }
// int max;
// if (a > b) //условие
// {
//     max = a; //если условие истина
// }
// else // иначе
// {
//    max = b; //если условие ложь
// }
// Console.WriteLine(max);

// цикл - конструкция, выполняющая рутинные 
//в обратном порядке
// int count = 10;
// while (count > 0)
// {
//     Console.WriteLine(count);
//     count = count -1;
// }

//в прямом порядке
// int count = 1;
// while (count <= 10)
// {
//     Console.WriteLine(count);
//     count++;
// // }

// //Нужно посчитать количество чисел из отрезка [2, 128],
// //котоые делятся на 3, 5
// int start = 2;
// int end = 128;
// int count = 0;

// while (count <= 130) //start <= end
// {
//     Console.WriteLine(count);
//     count++;
// }

// bool flag1 = count % 3 == 0; // остаток от деления на 3 равно 1
// bool flag2 = count % 5 == 0;
// bool result = flag1 && flag2; //&& знак конЪюнкции, то есть оба условия должны быть

// //Console.WriteLine(flag1);
// //Console.WriteLine(flag2);
// Console.WriteLine(result);

// вариант Сергея
int start = 2;
int end = 128;
int count = 0;
while (start <= end)
{
    if ((start % 3 == 0) && (start % 5 == 0))
    {
        count++;
        Console.WriteLine($"{count}: {start}");
    }
    start++;
}
Console.WriteLine($"count = {count}");