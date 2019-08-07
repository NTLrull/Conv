using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class CheckCharInHoursStr
    {
        // Поле со значением, введенным в поле часов
        public string hours_str;

        public CheckCharInHoursStr(string hours_str)
        {
            // Присвоение полю words класса результат, полученный в методе NumberToWords
            this.hours_str = CheckSymbolsIntStr(hours_str);
        }

        // Метод, преобразующий числовое значение минут в пропись
        public static string CheckSymbolsIntStr(string hours_str)
        {
            // Инициализация массива символов. Присвоение ему данных строки
            char[] hours_array_of_char = hours_str.ToCharArray();

            // Массив с допустимыми значениями символов
            char[] correct_symbols_array = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.', ',' };

            // Перебор символов массива для проверки на их соответствие требуемым значениям
            for (int n_elm = 0; n_elm < hours_array_of_char.Length; n_elm++)
            {
                // Возможность ввода отрицательного значения
                if (hours_array_of_char[0] == '-')
                {
                    continue;                
                }

                // Проверка того, что перебираемые символы соответствуют допустимым
                if (!correct_symbols_array.Contains(hours_array_of_char[n_elm]))
                {
                    return hours_str = "";
                }  

                // Замена разделителя "." на ","
                if (hours_array_of_char[n_elm] == '.')
                {
                    hours_array_of_char[n_elm] = ',';
                } 
            }

            // Присвоение переменной значения пустой строки при вводе значения, равного "-"
            if ((hours_array_of_char[0] == '-') && (hours_array_of_char.Length == 1))
            {
                return hours_str = "";            
            }

            // Инициализация переменной, предназначенной для подсчета количества разделителей
            int number_of_commas = 0;

            // Перебор элементов массива для подсчета разделителей
            foreach (char hours_elm in hours_array_of_char)
            {                
                // Проверка того, является ли символ разделителем
                if (hours_elm == ',')
                {
                    number_of_commas++;
                }
            }

            // Возврат пустой строки при количестве разделителей большим 1
            if (number_of_commas > 1)
            {
                return hours_str = "";
            }

            // Присвоение переменной пустой строки
            hours_str = "";

            // Конкатенация символов в строку
            foreach (char hours_elm in hours_array_of_char)
            {
                hours_str += hours_elm;
            }

            // Возвращение исходной переменной hours_str
            return hours_str;
        }
    }
}
