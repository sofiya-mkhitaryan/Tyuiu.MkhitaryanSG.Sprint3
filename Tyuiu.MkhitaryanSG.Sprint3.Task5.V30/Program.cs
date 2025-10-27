//при Х=2
//Вложенные циклы
//Написать программу, которая вычисляет сумму сумм ряда по формуле, при х = 2
using Tyuiu.MkhitaryanSG.Sprint3.Task5.V30.Lib;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнила: Мхитарян С. Г. | РППб-25-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #3                                                                 *");
        Console.WriteLine("* Тема: Вложенные циклы                                                     *");
        Console.WriteLine("* Задание #5                                                                *");
        Console.WriteLine("* Вариант #30                                                               *");
        Console.WriteLine("* Выполнила: Мхитарян София Геворковна | РППб-25-1                          *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("* Написать программу, которая вычисляет сумму сумм ряда                     *");
        Console.WriteLine("* по формуле, при х = 2                                                     *");
        Console.WriteLine("*****************************************************************************");

        DataService ds = new DataService();
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                           *");
        Console.WriteLine("*****************************************************************************");

        int x = 2;
        int startValue1 = 1;
        int stopValue1 = 11;
        int startValue2 = 1;
        int stopValue2 = 3;

        Console.WriteLine("Старт шага первой суммы = " + startValue1);
        Console.WriteLine("Конец шага первой суммы = " + stopValue1);
        Console.WriteLine("Старт шага второй суммы = " + startValue2);
        Console.WriteLine("Конец шага второй суммы = " + stopValue2);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Сумма ряда = " + ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2));

        Console.ReadKey();
    }
}