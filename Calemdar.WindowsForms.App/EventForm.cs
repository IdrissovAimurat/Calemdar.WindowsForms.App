using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calemdar.WindowsForms.App
{
    public partial class EventForm : Form
    {

        private string logFilePath = "C:\\Аймекешка дз\\4 курс 1 семестр\\c#\\emtixan\\Calendar\\file.txt";
        // соединение к бд
        String connString = "server=localhost;user id=root;database=db_calendar;sslmode=None";


        public EventForm()
        {
            InitializeComponent();
        }
        private void EventForm_Load(object sender, EventArgs e)
        {
            txtDate.Text = UserControlDays.static_day + "-" + MainFormCalendar.static_month + "-" + MainFormCalendar.static_year;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();

                String sql = "INSERT INTO tbl_calendar(date, event) VALUES (?, ?)";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("date", txtDate.Text);
                cmd.Parameters.AddWithValue("event", txtEvent.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Сохранено");

                // Запись в лог при успешной операции
                LogToFile("Событие добавлено в базу данных.");

                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                // Запись в лог при возникновении ошибки
                LogToFile("Ошибка: " + ex.Message);
                MessageBox.Show("Произошла ошибка при сохранении события.");
            }
        }


        private void LogToFile(string message)
        {
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }
        }

        private void codeeloTextBox1_TextWasChanged(object sender, EventArgs e)
        {

        }
        private void codeeloTextBox2_TextWasChanged(object sender, EventArgs e)
        {

        }


    }
}
