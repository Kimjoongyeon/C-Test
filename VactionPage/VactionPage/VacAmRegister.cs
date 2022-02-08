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
        //create a connectionstring
        String connString = "server=127.0.0.1; Initial Catalog=code;Integrated Security=SSPI";
        //I already created a database using xampp
        public VacAmRegister()
        {
            InitializeComponent();
        }
        private void VacAmRegister_Load(object sender, EventArgs e)
        {
            // 날짜 정적변수들 받아와서 날짜 기록하기
            txDate.Text = VactionChoice.static_year +"/"+ VactionChoice.static_month + "/" + UserControlDays.static_day;
            VactionChoice vacChoice = new VactionChoice();


            lbName.Text += vacChoice.LoginData;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            String sql = "INSERT INTO Vaction(date, reason, name)VALUES(@fDate, @fReason, @fName)";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@fDate", txDate.Text);
            cmd.Parameters.AddWithValue("@fReason", txReason.Text);
            cmd.Parameters.AddWithValue("@fName", lbName.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("등록이 완료되었습니다.");
            cmd.Dispose();
            con.Close();
            this.Close();
        }
    }
}
