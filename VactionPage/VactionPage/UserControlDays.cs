using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VactionPage
{
    public partial class UserControlDays : UserControl
    {
        String connString = "server=127.0.0.1; Initial Catalog=code;Integrated Security=SSPI";
        //정적변수생성
        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connString); 
            con.Open();
            String sql = "SELECT * FROM totalVaction where date = @fDate";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@fDate", VactionChoice.static_year + "-" + VactionChoice.static_month + "-" + lbdays.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lbAmEvent.Text = reader["userID"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
            con.Close();
        }
        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }
        //am pm 구분
        private void panelAM_MouseHover(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.BackColor = Color.LightPink;
        }

        private void panelAM_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.BackColor = Color.White;
        }

        private void panelPM_MouseHover(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.BackColor = Color.LightSkyBlue;
        }

        private void panelPM_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.BackColor = Color.White;
        }

        private void panelAM_Click(object sender, EventArgs e)
        {
            //휴가요청할수있게해야함
            static_day = lbdays.Text;
            timer1.Start();
            VacAmRegister vacAmRegister = new VacAmRegister();
            vacAmRegister.ShowDialog();
        }

        private void panelPM_Click(object sender, EventArgs e)
        {
            //휴가요청할수있게해야함
            static_day = lbdays.Text;
            VacPmRegister vacPmRegister = new VacPmRegister();
            vacPmRegister.ShowDialog();
        }

        //Create a new method to display event
        private void displayEvent()
        {
            
            SqlConnection con = new SqlConnection(connString); 
            con.Open();
            String sql = "SELECT * FROM Vaction where date = @fDate";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@fDate", VactionChoice.static_year + "-" + VactionChoice.static_month + "-" + lbdays.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lbAmEvent.Text = reader["userID"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
            con.Close();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
    }
}
