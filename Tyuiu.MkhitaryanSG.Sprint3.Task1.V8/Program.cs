//Оператор цикла while
//Написать программу используя цикл while, которая вычисляет произведение ряда по формуле, при х=0,25
using Tyuiu.MkhitaryanSG.Sprint3.Task1.V8.Lib;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнила: Мхитарян С. Г. | РППб-25-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #3                                                                 *");
        Console.WriteLine("* Тема: Оператор цикла while                                                *");
        Console.WriteLine("* Задание #1                                                                *");
        Console.WriteLine("* Вариант #8                                                                *");
        Console.WriteLine("* Выполнила: Мхитарян София Геворковна | РППб-25-1                          *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение   *");
        Console.WriteLine("* ряда по формуле, при х=0,25                                               *");
        Console.WriteLine("*****************************************************************************");

        DataService ds = new DataService();
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                           *");
        Console.WriteLine("*****************************************************************************");

        double value = 0.25;
        int startValue = 1;
        int stopValue = 7;

        Console.WriteLine("Переменная Х = " + value);
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Произведение ряда = " + ds.GetSumSeries(value, startValue, stopValue));

        Console.ReadKey();
    }
}