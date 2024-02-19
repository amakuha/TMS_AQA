// See https://aka.ms/new-console-template for more information

{
    //Задание 1 (консольный калькулятор)

    Console.WriteLine("Задание 1, Консольный калькулятор");

    Console.Write("Введите первое число: ");
    double number1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите операцию: +, -, *, / ");
    string operation = Console.ReadLine();

    Console.Write("Введите второе число: ");
    double number2 = Convert.ToDouble(Console.ReadLine());

    if (operation == "/" && number2 == 0)
        Console.WriteLine("Деление на ноль запрещено");
    else
    {
        switch (operation)
        {
            case "+":
                Console.WriteLine($"Результат: {number1 + number2}");
                break;
            case "-":
                Console.WriteLine($"Результат: {number1 - number2}");
                break;
            case "*":
                Console.WriteLine($"Результат: {number1 * number2}");
                break;
            case "/":
                Console.WriteLine($"Результат: {number1 / number2}");
                break;
            default:
                Console.WriteLine($"Неверно выбрана операция");
                break;
        }
    }

    //Задание 2 (определение попадания числа в интервал)

    Console.WriteLine();
    Console.WriteLine("Задача 2, определение интервала");
 
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number > 50 || number < -50)
        Console.WriteLine("Число не входит в промежуток от -50 до 50");

    else if (number >= -40 && number <= -10)
        Console.WriteLine("Число входит в промежуток [-40, -10]");

    else if (number >= -9 && number <= 0)
        Console.WriteLine("Число входит в промежуток [-9, 0]");

    else if (number >= 1 && number <= 10)
        Console.WriteLine("Число входит в промежуток [1, 10]");

    else if (number >= 11 && number <= 40)
        Console.WriteLine("Число входит в промежуток [11, 40]");

    else
        Console.WriteLine("Число не входит ни в один из имеющихся промежутков");

    //Задание 3 (перевод слов)

    Console.WriteLine();
    Console.WriteLine("Задача 3, перевод слов");
    
    Console.Write("Введите слово на русском языке: ");
    string? weather = Console.ReadLine();

    Console.WriteLine($"Перевод: {Translate(weather)}");

    string Translate(string word)
    {
        string result = word switch
        {
            "солнечно" => "sunny",
            "дождь" => "rain",
            "снег" => "snow",
            "холодно" => "cold",
            "облачно" => "cloudy",
            "ветер" => "wind",
            "радуга" => "rainbow",
            "туман" => "fog",
            "безоблачно" => "cloudless",
            "гроза" => "thunderstorm",
            _ => "Слово отсутствует в словаре",
        };
        return result;
    }

    //Задание 4, алгоритм 1 (определение четности)

    Console.WriteLine();
    Console.WriteLine("Задача 4, опеределение четности");

    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num % 2 == 0)
        Console.WriteLine($"Число {num} четное");
    else
        Console.WriteLine($"Число {num} нечетное");


    //Задание 4, алгоритм 2 (определение четности)

    Console.WriteLine();
    Console.WriteLine("Задача 4, опеределение четности");

    Console.WriteLine("Введите число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    if ((num1 % 10 == 0) || (num1 % 10 == 2) || (num1 % 10 == 4) || (num1 % 10 == 6) || (num1 % 10 == 8))
        Console.WriteLine($"Число {num1} четное");
    else
        Console.WriteLine($"Число {num1} нечетное");


}
