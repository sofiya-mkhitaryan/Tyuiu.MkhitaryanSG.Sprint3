//Оператор цикла foreach
//Используя цикл foreach заменить буквы g на цифру 4 в строке: gft hggt ntg
using Tyuiu.MkhitaryanSG.Sprint3.Task3.V7.Lib;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнила: Мхитарян С. Г. | РППб-25-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #3                                                                 *");
        Console.WriteLine("* Тема: Оператор цикла foreach                                              *");
        Console.WriteLine("* Задание #3                                                                *");
        Console.WriteLine("* Вариант #7                                                                *");
        Console.WriteLine("* Выполнила: Мхитарян София Геворковна | РППб-25-1                          *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("* Используя цикл foreach                                                    *");
        Console.WriteLine("* заменить буквы g на цифру 4 в строке: gft hggt ntg                        *");
        Console.WriteLine("*****************************************************************************");

        DataService ds = new DataService();
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                           *");
        Console.WriteLine("*****************************************************************************");

        string value = "gft hggt ntg";
        char replaceable = 'g';
        char replacement = '4';

        Console.WriteLine("Исходная строка = " + value);
        Console.WriteLine("Какой символ заменяем = " + replaceable);
        Console.WriteLine("На что заменяем = " + replacement);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Полученный результат после замены = " + ds.ReplaceCharOnNum(value, replaceable, replacement));

        Console.ReadKey();
    }
}