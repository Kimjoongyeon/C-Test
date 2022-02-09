using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VactionPage
{
    public partial class VacAmRegister : Form
    {
        String connString = "server=127.0.0.1; Initial Catalog=code;Integrated Security=SSPI";

        public VacAmRegister()
        {
            InitializeComponent();
            
        }
        

        private void VacAmRegister_Load(object sender, EventArgs e)
        {
            lbId.Text = Form1.LoginInfo.userId;
            // 날짜 정적변수들 받아와서 날짜 기록하기
            txDate.Text = VactionChoice.static_year +"/"+ VactionChoice.static_month + "/" + UserControlDays.static_day;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connString);
            txId.Text = Form1.LoginInfo.userId;
            con.Open();
            String sql = "INSERT INTO Vaction(date, reason, id, time, status)VALUES(@date, @reason, @id, @time, @status)";
            //sql = "select *, yearVaction - @useVaction as remainVaction from Vaction";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@date", txDate.Text);
            cmd.Parameters.AddWithValue("@reason", txReason.Text);
            cmd.Parameters.AddWithValue("@id", txId.Text);
            cmd.Parameters.AddWithValue("@time", "AM");
            //cmd.Parameters.AddWithValue("@useVaction", -0.5);
            cmd.Parameters.AddWithValue("@status", 0);
            cmd.ExecuteNonQuery();
            MessageBox.Show("등록이 완료되었습니다.");
            cmd.Dispose();
            con.Close();
            this.Close();
        }
    }
}
