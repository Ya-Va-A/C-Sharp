// Задать положительное вещественное число m. Cоставить целое число n из цифр

// десятков и сотых m
// единиц и сотых m
// сотен и десятых m

//вещественные числа - double

double m = 23.567;
int desyatki (int n)
{
    int result = 0;
    result = n % 100;
    return result; 
}
//int number = N / 100 % 10; // сотни
//       // int number = N % 10; // единицы
//       //if (N < 100) Console.WriteLine("No 3rd symbol");
// Console.WriteLine($"Ответ {number}");