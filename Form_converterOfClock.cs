using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Project
{
    public partial class Form_converterOfClock : Form
    {
        public Form_converterOfClock()
        {
            InitializeComponent();
        }

        private void button_convert_Click(object sender, EventArgs e)
        {
            // Инициализация переменной hours_str и присвоение ей введенного textBox значения часов
            string hours_str= tBox_hours.Text;

            if (hours_str.Length >= 3)
            {
                // Получение подстроки без последних трех символов от hours_str
                string hours_substr1 = hours_str.Substring(0, hours_str.Length - 3);

                // Получение подстроки с последними 2 символами строки hours_str
                string hours_substr2 = hours_str.Substring(hours_str.Length - 2);

                // Проверка того, что последние 2 символа строки равны "ч."
                if (hours_substr2 == "ч.")
                {
                    hours_str = hours_substr1;
                }            
            }
            
            // Создание экземпляра класса CheckCharInHoursStr, производящего проверку введенных символов
            CheckCharInHoursStr checkCharInHoursStr = new CheckCharInHoursStr(hours_str);

            // Присвоение переменной hours_str проверенного значения
            hours_str = checkCharInHoursStr.hours_str;

            // Проверка на корректность введенного значения
            if (hours_str == "")
            {
                MessageBox.Show("Было введено некорректное значение");
                tBox_hours.Clear();
                label_minutes.Text = "";
            }
            else
            {
                // Преобразование строковой переменной в переменную типа float и присвоение полученного значения переменной hours_int
                decimal hours_int = Convert.ToDecimal(hours_str);

                // Проверка верхней границы для переменной hours_int
                if (hours_int > 1000)
                {
                    MessageBox.Show("Значение в поле не должно превышать 1000.");
                    tBox_hours.Clear();
                    label_minutes.Text = "";
                }
                // Проверка нижней границы для переменной hours_int
                else if (hours_int < 0)
                {
                    MessageBox.Show("Значение в поле должно быть больше или равно 0.");
                    tBox_hours.Clear();
                    label_minutes.Text = "";
                }
                else
                {
                    // Инициализация переменной minutes_int и присвоение ей значения минут
                    int minutes_int = Convert.ToInt32(hours_int * 60);

                    // Создание экземпляра класса ConverterIntToStr, производящего преобразования численного значения минут в пропись
                    ConvertIntToStr numberToWords = new ConvertIntToStr(minutes_int);

                    // Отображение количества минут прописью в элементе label_minutes
                    label_minutes.Text = numberToWords.minutes_str_line;
                }                               
            }            

        }
    }
}
