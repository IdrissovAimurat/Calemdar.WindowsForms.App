using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calemdar.WindowsForms.App
{
    public partial class MainFormCalendar : Form
    {
        public static int static_month, static_year;

        int month;
        int year;
        public MainFormCalendar()
        {
            InitializeComponent();
        }
        private void MainFormCalendar_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;

            month = now.Month;
            year = now.Year;

            String mounthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LabelDate.Text = mounthName + " " + year;

            static_month = month;
            static_year = year;

            DateTime StartOfTheMonth = new DateTime(year, month, 1); // тут получим первый день месяца.

            int days = DateTime.DaysInMonth(year, month); // тут получаем количество дней в месяце

            int dayOfTheWeek = Convert.ToInt32(StartOfTheMonth.DayOfWeek.ToString("d")) - 1; //тут преобразовывается крч начало месяца в целое

            // еще должно быть создание пустого пользовательского элемента управления

            for (int i = 1; i <= dayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                DayContainer.Controls.Add(ucblank);
            }
            // тут создать usercontrol для дней
            for (int i = 1; i <= days; i++) 
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                DayContainer.Controls.Add(ucdays);
            }
        }
        /// <summary>
        ///     Следующий месяц
        /// </summary>

        private void button1_Click(object sender, EventArgs e) 
        {
            DayContainer.Controls.Clear();
            month++; // - след месяц по инкременту пойдет так, как в обычном календаре
            static_month = month;
            static_year = year;

            String mounthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LabelDate.Text = mounthName + " " + year;

            if (month > 12)
            {
                month = 1;
                year++;
            }

            DateTime now = DateTime.Now;

            DateTime StartOfTheMonth = new DateTime(year, month, 1); // тут получим первый день месяца.

            int days = DateTime.DaysInMonth(year, month); // тут получаем количество дней в месяце

            int dayOfTheWeek = Convert.ToInt32(StartOfTheMonth.DayOfWeek.ToString("d")) - 1; //тут преобразовывается крч начало месяца в целое

            // еще должно быть создание пустого пользовательского элемента управления

            for (int i = 1; i <= dayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                DayContainer.Controls.Add(ucblank);
            }
            // тут создать usercontrol для дней
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                DayContainer.Controls.Add(ucdays);
            }
        }

        /// <summary>
        ///     Предыдущий месяц
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            DayContainer.Controls.Clear();
            month--; // - предылущий месяц по дикременту пойдет так, как и в обычном календаре
            static_month = month;
            static_year = year;

            //if (month < 12)
            if (month < 1)
            {
                month = 12;
                year--;
            }

            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LabelDate.Text = monthName + " " + year;

            DateTime now = DateTime.Now;

            DateTime StartOfTheMonth = new DateTime(year, month, 1); // Получает первый день месяца.

            int days = DateTime.DaysInMonth(year, month); // Получаем количество дней в месяце

            int dayOfTheWeek = Convert.ToInt32(StartOfTheMonth.DayOfWeek.ToString("d")) - 1; // Преобразуется начало месяца в целое

            if (dayOfTheWeek < 0)
            {
                dayOfTheWeek = 6; // Воскресенье (DayOfWeek.Sunday) имеет значение 0, мы заменяем его на 6.
            }

            // еще должно быть создание пустого пользовательского элемента управления

            for (int i = 1; i <= dayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                DayContainer.Controls.Add(ucblank);
            }
            // тут создать usercontrol для дней
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                DayContainer.Controls.Add(ucdays);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
