//Использование операторов continue и break в циклах
//На отрезке, где x принимает значения от -5 до 5, вычислить значение функции y=sin(x)/cos(x)
//При х = 0 прервать цикл. Полученные значения перемножать.
using Tyuiu.MkhitaryanSG.Sprint3.Task4.V13.Lib;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнила: Мхитарян С. Г. | РППб-25-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #3                                                                 *");
        Console.WriteLine("* Тема: Использование операторов continue и break в циклах                  *");
        Console.WriteLine("* Задание #4                                                                *");
        Console.WriteLine("* Вариант #13                                                               *");
        Console.WriteLine("* Выполнила: Мхитарян София Геворковна | РППб-25-1                          *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение       *");
        Console.WriteLine("* функции y=sin(x)/cos(x) При х = 0 прервать цикл. Перемножать              *");
        Console.WriteLine("*****************************************************************************");

        DataService ds = new DataService();
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                           *");
        Console.WriteLine("*****************************************************************************");

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Сумма ряда = " + ds.Calculate(startValue, stopValue));

        Console.ReadKey();
    }
}