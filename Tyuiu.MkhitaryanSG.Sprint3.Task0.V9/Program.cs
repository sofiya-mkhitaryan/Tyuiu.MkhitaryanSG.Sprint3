//Оператор цикла for
//Написать программу используя цикл for, которая вычисляет сумму ряда по формуле, при x = 0,5
using Tyuiu.MkhitaryanSG.Sprint3.Task0.V9.Lib;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнила: Мхитарян С. Г. | РППб-25-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #3                                                                 *");
        Console.WriteLine("* Тема: Оператор цикла for                                                  *");
        Console.WriteLine("* Задание #0                                                                *");
        Console.WriteLine("* Вариант #9                                                                *");
        Console.WriteLine("* Выполнила: Мхитарян София Геворковна | РППб-25-1                          *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда       *");
        Console.WriteLine("*  по формуле, при x = 0,5                                                  *");
        Console.WriteLine("*****************************************************************************");

        DataService ds = new DataService();
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                           *");
        Console.WriteLine("*****************************************************************************");

        double value = 0.5;
        int startValue = 1;
        int stopValue = 15;

        Console.WriteLine("Переменная Х = " + value);
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));

        Console.ReadKey();
    }
}