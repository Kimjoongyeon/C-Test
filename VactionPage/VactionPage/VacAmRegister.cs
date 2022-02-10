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
<<<<<<< HEAD
            String sql = "INSERT INTO Vaction(date, reason, id, am, status)VALUES(@date, @reason, @id, @am, @status)";
=======
            String sql = "INSERT INTO Vaction(id, date, reason, userID, am, status)VALUES(IsNull((SELECT MAX(ID) FROM Vaction), 0) + 1, @date, @reason, @userID, @am, @status)";
            String totalPlus = "INSERT INTO totalVaction (id, userID) VALUES (@id, @userID)";
>>>>>>> b3d6ffccaffa5218e15022a2e18d7685fbd1b71d
            //sql = "select *, yearVaction - @useVaction as remainVaction from Vaction";
            SqlCommand cmd = con.CreateCommand();
            SqlCommand totalCmd = con.CreateCommand();
            cmd.CommandText = sql;
            totalCmd.CommandText = totalPlus;
            
            cmd.Parameters.AddWithValue("@date", txDate.Text);
            cmd.Parameters.AddWithValue("@reason", txReason.Text);
<<<<<<< HEAD
            cmd.Parameters.AddWithValue("@id", txId.Text);
            cmd.Parameters.AddWithValue("@am", "AM");
=======
            cmd.Parameters.AddWithValue("@userID", txId.Text);
            cmd.Parameters.AddWithValue("@am", "휴가");
>>>>>>> b3d6ffccaffa5218e15022a2e18d7685fbd1b71d
            //cmd.Parameters.AddWithValue("@useVaction", -0.5);
            cmd.Parameters.AddWithValue("@status", 0);
            totalCmd.Parameters.AddWithValue("@id", 1);
            totalCmd.Parameters.AddWithValue("@userID", txId.Text);
            cmd.ExecuteNonQuery();
            totalCmd.ExecuteNonQuery();
            MessageBox.Show("등록이 완료되었습니다.");
            cmd.Dispose();
            totalCmd.Dispose();
            con.Close();
            this.Close();
        }
    }
}
