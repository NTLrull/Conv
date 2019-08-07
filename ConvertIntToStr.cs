using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class ConvertIntToStr
    {
        // Поле со строковой переменной, отображающей значения минут
        public string minutes_str_line;

        public ConvertIntToStr(int minutes_int)
        {
            // Присвоение полю words класса результат, полученный в методе NumberToWords
            this.minutes_str_line = ConvertNumberToWords(minutes_int) + " мин.";
        }

        // Метод, преобразующий числовое значение минут в пропись
        public static string ConvertNumberToWords(int minutes_int)
        {
            // Проверка на равенство переменной нулю и возвращение строки "ноль минут"
            if (minutes_int == 0)
                return "ноль";

            // Инициализация и присвоение переменной minutes_str_line пустой строки
            string minutes_str_line = "";

            // Выделение значений тысяч
            if ((minutes_int / 1000) > 0)
            {
                // Присвоение переменной minutes_str_line количества тысяч в переменной minutes_int 
                minutes_str_line += ConvertNumberToWords(minutes_int / 1000) + " тысяч ";    // Не учтен родительный падеж

                // Присвоение переменной minutes_int остатка от деления на 1000
                minutes_int %= 1000;
            }

            // Выделение значений сотен
            if ((minutes_int / 100) > 0)
            {
                // Присвоение переменной minutes_str_line количества сотен в переменной minutes_int
                minutes_str_line += ConvertNumberToWords(minutes_int / 100) + " сотен ";

                // Присвоение переменной minutes_int остатка от деления на 100
                minutes_int %= 100;
            }

            // Выделение значений десятков и единиц
            if (minutes_int > 0)
            {
                // При наличии значений тысяч и/или сотен, добавить союз "и"
                if (minutes_str_line != "")
                    minutes_str_line += "и ";

                // Инициализация и присвоение значений массиву строк для 0-19
                var units_map = new[] { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять", "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
                
                // Инициализация и присвоение значений массиву строк для десятков
                var tens_map = new[] { "ноль", "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };

                // Определение массива, из которого будут присваиваться значения для переменной minutes_str_line
                if (minutes_int < 20)

                    // Присвоение переменной minutes_str_line значения от 0 до 20
                    minutes_str_line += units_map[minutes_int];
                else
                {
                    // Присвоение переменной minutes_str_line значения десятков
                    minutes_str_line += tens_map[minutes_int / 10];

                    // Проверка на наличия единиц в переменной minutes_int и присвоение их переменной minutes_str_line
                    if ((minutes_int % 10) > 0)
                        minutes_str_line += "-" + units_map[minutes_int % 10];
                }
            }
             
            // Возвращение переменной minutes_str_line, с прописью значения минут 
            return minutes_str_line;
        }
    }
}
