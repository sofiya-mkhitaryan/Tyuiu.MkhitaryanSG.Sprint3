//Обработка целочисленной информации
//Напишите программу, которая ищет среди целых чисел, принадлежащих числовому отрезку [14, 20] сумму всех делителей больше 9
using Tyuiu.MkhitaryanSG.Sprint3.Task6.V27.Lib;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнила: Мхитарян С. Г. | РППб-25-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #3                                                                 *");
        Console.WriteLine("* Тема: Обработка целочисленной информации                                  *");
        Console.WriteLine("* Задание #6                                                                *");
        Console.WriteLine("* Вариант #27                                                               *");
        Console.WriteLine("* Выполнила: Мхитарян София Геворковна | РППб-25-1                          *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих         *");
        Console.WriteLine("* числовому [14, 20] сумму всех делителей больше 9                          *");
        Console.WriteLine("*****************************************************************************");

        DataService ds = new DataService();
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                           *");
        Console.WriteLine("*****************************************************************************");

        int startValue = 14;
        int stopValue = 20;

        Console.WriteLine("Старт шага суммы = " + startValue);
        Console.WriteLine("Конец шага суммы = " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Сумма ряда = " + ds.GetSumTheDivisors(startValue, stopValue));

        Console.ReadKey();
    }
}