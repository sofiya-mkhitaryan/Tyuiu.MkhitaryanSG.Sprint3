//Добавление к решению итоговых проектов по спринту
using Tyuiu.MkhitaryanSG.Sprint3.Task7.V23.Lib;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнила: Мхитарян С. Г. | РППб-25-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #3                                                                 *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                   *");
        Console.WriteLine("* Задание #7                                                                *");
        Console.WriteLine("* Вариант #23                                                               *");
        Console.WriteLine("* Выполнила: Мхитарян София Геворковна | РППб-25-1                          *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("* Напишите программу, которая выводит таблизу значений функции:             *");
        Console.WriteLine("* 4 - 2*x + (2+cos(x)/2*x-2) значений [-5; 5]                               *");
        Console.WriteLine("*****************************************************************************");

        DataService ds = new DataService();
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                           *");
        Console.WriteLine("*****************************************************************************");

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);

        int len = ds.GetMassFunction(startValue, stopValue).Length;

        double[] valueArray;

        valueArray = new double[len];
        valueArray = ds.GetMassFunction(startValue, stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("+-------+--------+");
        Console.WriteLine("|  X    |   f(x) |");
        Console.WriteLine("+-------+--------+");
        for ( int i = 0;  i <= len-1; i++ )
        {
            Console.WriteLine("|{0,5:d}  |{1, 5:f2}   |", startValue, valueArray[i]);
            startValue++;
        }
        Console.WriteLine("+-------+--------+");
        Console.ReadKey();
    }
}