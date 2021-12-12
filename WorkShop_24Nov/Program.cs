// ## Консольная игра "Угадай число"

// Комп загадывает число (в некотором отрезке), 
// у игрока есть несколько попыток, чтобы угадать это число
// Игрок вводит различные числа, комп считает количество попыток,
// а также "говорит" введенное число больше или меньше загаданного.


// 1. Нам необходимо задать исходные (обозначить условия). Отрезок (минимальное и максимальное значение), количество попыток. Один способ - задать как константы, второй способ - запросить у игрока. 
// 2. Инициализировать игру. Загадываем число и приветсвуем игрока, объясняем условия игры.
// 3. Делаем ход. Запрашиваем и получаем от игрока число. Сравниваем это число с загаданным, изменяем количество попыток и выводим результат.
// 4. Завершение игры (Если человек угадал, либо потратил все попытки). Либо предложить сыграть еще раз.

// * GameInit() - метод, который задает все исходные значения в вашей игре.
// * MakeMove() - ходы, задаются этим методом.
// * RequestNumber() - запрос числа у игрока, обработка нештатных ситуаций.
// * CheckNumber(int PlayesrNumber, int SecretNumber)
// * GameOver(bool winner) - 

// задаем диапазон
int minValue = 1;
int maxValue = 100;
int count = 0;

int RequestNumber (string attampt)
{
    Console.WriteLine("Введите число");
    string attempt = Console.ReadLine();
    return Convert.ToInit32(attempt);
}

// вариант метода, который проверяет тип символа:
//     int RequestNumber(string attempt) // задать число
// {
//     while (true)
//     {
//         Console.WriteLine("Введите число");
//         if (int.TryParse(Console.ReadLine(), out int num)) return num;
//         else Console.WriteLine("Что-то вы не то ввели, давайте-ка снова.");
//     }
// }

int CreateSecretNum (int minValue, int maxValue)
{
    int SecretNum = new Random().Next (minValue, maxValue);
    return SecretNum;
}

bool MakeMove (int RequestNumber, int CreateSecretNum)
{
    if (RequestNumber == CreateSecretNum)
    {
        Console.WriteLine("Вы угадали");
        return true;
    }
    else if (RequestNumber > CreateSecretNum)
    {
        Console.WriteLine ("Ваше число больше");
        return false;
    }
    else
    {
        Console.WriteLine ("Ваше число меньше");
        return false;
    }
}

if MakeMove () = (false);
{
    for (count <=7, count ++)
    {
        Console.WriteLine ($"У Вас осталось {count} попыток");
    }
}
