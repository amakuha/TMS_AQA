// See https://aka.ms/new-console-template for more information

{
    /*
    Console.WriteLine("Hello, World!");
    Console.WriteLine("It's a nice day!");

    const int MINUTS_IN = 60;

    string name;

    name = "Bob";
    Console.WriteLine(name);

    name = "Bob1";
    Console.WriteLine(name);

    name = "Bob2";
    Console.WriteLine(name);

    Console.WriteLine(true);
    Console.WriteLine(false);

    Console.WriteLine(-10);
    Console.WriteLine(0);
    Console.WriteLine(1.24);
    Console.WriteLine(1.24F);

    Console.WriteLine('H');

    Console.WriteLine("It's a \t nice day!"); 
    Console.WriteLine("It's a \n nice day!"); //перенос на другую строку

    bool flag = true;
    flag = false;

    float a = 3.14F;

    var d = 10;
    var d1 = "test";

    int j;
    j = 10;
    */

    /*
    Console.WriteLine("Добро пожаловать в с#");
    Console.Write("Надеюсь Вы ");
    Console.Write("постигнете с# \n");
    Console.WriteLine("и всё");
    */
    /*
    int j;
    j = 20;

    Console.WriteLine("J = " + j);

    string name = "TOM";
    int age = 34;
    double height = 1.7;

    Console.WriteLine($"Имя {name} Возраст {age} Вес {height}");
    Console.WriteLine("Имя {0} Возраст {2} Вес {1}", name,height,age);
    */

    /* Console.WriteLine("Введите своё имя: ");
     string? name = Console.ReadLine();
     Console.WriteLine($"Ваше имя: {name}");

     Console.WriteLine("Введите свой возраст: ");
     string? age_str = Console.ReadLine();
     int age = Convert.ToInt32(age_str);
     Console.WriteLine($"Ваш возраст: {age}");

     byte a = 4;
     byte b = (byte)(a + 70);
    */


    /*
       // Решение нашей задачи
       // Подготовка данных
       bool isWhiteBreadFresh = true;
       ushort whiteBreadPrice = 150;
       ushort butterPrice = 230;
       ushort milkPrice = 170;
       float milkFatPercentage = 1.2F;
       ushort icecreaPrice = 350;

       Console.Write("Введите начальную сумму: ");
       string? sumString = Console.ReadLine();
       short sum = Convert.ToInt16(sumString);

       if (sum > 0)
       {
           if (!isWhiteBreadFresh)
           {
               Console.WriteLine("Батон не свежий");
           }
           else if (sum >= whiteBreadPrice)
           {
               sum = Convert.ToInt16(sum - whiteBreadPrice);
               Console.WriteLine($"Купили свежий батон по цене {whiteBreadPrice}");
           }
           else
           {
               Console.WriteLine("На батон денег не хватает");
           }

           sum = (short)(sum - butterPrice);

           if (milkFatPercentage == 1.2F)
           {
               sum = Convert.ToInt16(sum - milkPrice);
           }

           if (sum >= icecreaPrice)
           {
               sum = Convert.ToInt16(sum - icecreaPrice);
           }

           Console.WriteLine($"Остаток суммы: {sum}");
       }
       else
       {
           Console.WriteLine("Сумма не может быть меньше 0");
       }
       */


int x = 6;

if (x == 1)
{
    Console.WriteLine("1");
}
else if (x == 2)
{
    Console.WriteLine("2");
}
else if (x == 3)
{
    Console.WriteLine("3");
}
else
{
    Console.WriteLine("Не соответствует условиям");
}

switch (x)
{
    case 1:
        Console.WriteLine("1");
        break;
    case 2:
        Console.WriteLine("2");
        break;
    case 3:
        Console.WriteLine("3");
        break;
    case 4:
        Console.WriteLine("4");
        break;
    default:
        Console.WriteLine("Не соответствует условиям");
        break;
}

string name = "Alex1";

switch (name)
{
    case "Alex":
        Console.WriteLine("Alex");
        break;
    case "Tom":
        Console.WriteLine("Tom");
        break;
}

string name1 = "Alex1";

switch (name1.Equals("Alex"))
{
    case true:
        Console.WriteLine("Alex");
        break;
    case false:
        Console.WriteLine("Tom");
        break;
}

Console.WriteLine(DoOperation(1));
Console.WriteLine(DoOperation(2));
Console.WriteLine(DoOperation(3));


int DoOperation(int x)
{
    switch (x)
    {
        case 1:
            return 1;
        case 2:
            return 2;
        default: return 0;
    }
}

int DoOperation1(int x)
{
    int result = x switch
    {
        1 => 1,
        2 => 2,
        _ => 0
    };

    return result;
}

int DoOperation2(int x) => x switch
{
    1 => 1,
    2 => 2,
    _ => 0
};



}
