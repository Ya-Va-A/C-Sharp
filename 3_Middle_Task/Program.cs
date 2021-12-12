//23. Показать таблицу квадратов чисел от 1 до N

int N = 15;
double[] Square(int N)
{
    double[] A = new double[N+1];
    for (int i = 1; i <= N; i++)
    {
        A[i] = Math.Pow(i, 2);
    }
    return A;
}

double[]B = Square(N);

double[] PrintArray(double[] b)
{
    for(int i = 1; i<b.Length; i++)
    {
        Console.WriteLine(b[i]);
    }
    return b;
}
PrintArray(B);


// 23. Показать таблицу квадратов чисел от 1 до N 
int N = 15;
double[] Square(int N)
{
    double[] A = new double[N+1];
    for (int i = 1; i <= N; i++)
    {
        A[i] = Math.Pow(i, 2);
    }
    return A;
}

double[]B = Square(N);

double[] PrintArray(double[] b)
{
    for(int i = 1; i<b.Length; i++)
    {
        Console.WriteLine(b[i]);
    }
    return b;
}
PrintArray(B);

//Найти кубы чисел от 1 до N


//Найти сумму чисел от 1 до А
int A = 5;
int Sum(int A)
{
    int sum = 0;
    for(int i=1; i<=A; i++)
    {
        sum = sum + i;
    }
    return sum;
}
Console.WriteLine($"Сумма чисел от 1 до {A} = {Sum(A)}");




// 23. Показать таблицу квадратов чисел от 1 до N 
int N = 15;
double[] Square(int N)
{
    double[] A = new double[N];
    for (int i = 0; i < N; i++)
    {
        A[i] = Math.Pow(i+1, 2);
    }
    return A;
}

double[]B = Square(N);

void PrintArray(double[] b)
{
    for(int i = 0; i<b.Length; i++)
    {
        Console.WriteLine(b[i]);
    }
}
PrintArray(B);





// ----------------------------------------------

// 24. Найти кубы чисел от 1 до N

// ----------------------------------------------

// 25. Найти сумму чисел от 1 до А

// ----------------------------------------------

// 26. Возведите число А в натуральную степень B используя цикл


// 26. Возведите число А в натуральную степень B используя цикл
double A = new Random().Next(-100,100);
int B = new Random().Next(1,15);
double NatDegree(double a, int d)
{
    double a1 = a;
    for(int i=1; i<d; i++)
    {
        a = a*a1;
    }
    return a;
}
Console.WriteLine($"{A} в степени {B} = {NatDegree(A, B)}");

// ----------------------------------------------

// 27. Определить количество цифр в числе

Console.WriteLine("Введите число");
string N = Console.ReadLine();
int Number(string n)
{
    int length = n.Length;
    return length;
}

Console.WriteLine($"В {N} {Number(N)} цифр");

// ----------------------------------------------

// 28. Подсчитать сумму цифр в числе

// ----------------------------------------------

// 29. Написать программу вычисления произведения чисел от 1 до N

// ----------------------------------------------

// 30. Показать кубы чисел, заканчивающихся на четную цифру


//----------------------

//нахождение цифры десятичного разряда N

