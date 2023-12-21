using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calemdar.WindowsForms.App
{
    
    public partial class UserControlDays : UserControl
    {
        String connString = "server=localhost;user id=root;database=db_calendar;sslmode=None";

        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public void days (int numday) 
        {
            labelDays.Text = numday+"";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = labelDays.Text;
            //таймер запускается, если в usercontrol_days указано значение click
            timer1.Start();
            EventForm eventForm = new EventForm();
            eventForm.Show();
        }
        // method, kotoryi show event

        private void displayEvent()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            String sql = "SELECT * FROM tbl_calendar where date = ?";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("date", UserControlDays.static_day + "-" + MainFormCalendar.static_month + "-" + MainFormCalendar.static_year + labelDays.Text);

            MySqlDataReader reader =  cmd.ExecuteReader();
            if(reader.Read()) 
            {
                labelEvent.Text = reader["event"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }

        private void labelEvent_Click(object sender, EventArgs e)
        {

        }
    }
}
