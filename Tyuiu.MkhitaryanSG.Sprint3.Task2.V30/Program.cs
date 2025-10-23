//Оператор цикла do-while
//Написать программу используя цикл do...while, которая вычисляет произведение ряда по формуле, при х=0,25
using Tyuiu.MkhitaryanSG.Sprint3.Task2.V30.Lib;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнила: Мхитарян С. Г. | РППб-25-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #3                                                                 *");
        Console.WriteLine("* Тема: Оператор цикла do-while                                             *");
        Console.WriteLine("* Задание #2                                                                *");
        Console.WriteLine("* Вариант #30                                                               *");
        Console.WriteLine("* Выполнила: Мхитарян София Геворковна | РППб-25-1                          *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("* Написать программу используя цикл do...while,                             *");
        Console.WriteLine("* которая вычисляет произведение ряда по формуле, при х=0,25                *");
        Console.WriteLine("*****************************************************************************");

        DataService ds = new DataService();
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                           *");
        Console.WriteLine("*****************************************************************************");

        double value = 0.25;
        int startValue = 1;
        int stopValue = 11;

        Console.WriteLine("Переменная Х = " + value);
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));

        Console.ReadKey();
    }
}