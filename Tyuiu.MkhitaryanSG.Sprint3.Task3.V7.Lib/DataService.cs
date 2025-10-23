using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MkhitaryanSG.Sprint3.Task3.V7.Lib
{
    public class DataService : ISprint3Task3V7
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            // Создаем StringBuilder для построения новой строки
            var result = new System.Text.StringBuilder();

            // Проходим по каждому символу в строке
            foreach (char currentChar in value)
            {
                // Если текущий символ совпадает с заменяемым, добавляем замену
                if (currentChar == replaceable)
                {
                    result.Append(replacement);
                }
                else
                {
                    // Иначе добавляем текущий символ
                    result.Append(currentChar);
                }
            }

            // Возвращаем результат в виде строки
            return result.ToString();
        }
    }
}
