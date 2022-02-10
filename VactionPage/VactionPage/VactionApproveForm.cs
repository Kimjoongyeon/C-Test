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
    public partial class VactionApproveForm : Form
    {
        String connString = "server=127.0.0.1; Initial Catalog=code;Integrated Security=SSPI";
        public VactionApproveForm()
        {
            InitializeComponent();
        }

        private void VactionApproveForm_Load(object sender, EventArgs e)
        {

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            String sql = "INSERT INTO totalVaction(date, reason, id, am, pm, status, yearVaction, remainVaction)VALUES" +
                "(@date, @reason, @id, @am, @pm, @status, @yearVaction, @remainVaction)";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@date", adminPage);
            cmd.Parameters.AddWithValue("@reason", adminPage);
            cmd.Parameters.AddWithValue("@id", adminPage);
            cmd.Parameters.AddWithValue("@am", "AM");
            //cmd.Parameters.AddWithValue("@useVaction", -0.5);
            cmd.Parameters.AddWithValue("@status", 0);
            cmd.ExecuteNonQuery();
            MessageBox.Show("등록이 완료되었습니다.");
            cmd.Dispose();
            con.Close();
            this.Close();
            /*
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            String sql = "UPDATE Vaction SET status = @status WHERE vactionNo = @No";
            //sql = "select *, yearVaction - @useVaction as remainVaction from Vaction";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@status", 1);
            cmd.Parameters.AddWithValue("@No", txNo.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("등록이 완료되었습니다.");
            cmd.Dispose();
            con.Close();
            this.Close();
            */
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            String sql = "UPDATE Vaction SET status = @status WHERE vactionNo = @No";
            //sql = "select *, yearVaction - @useVaction as remainVaction from Vaction";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@status", 2);
            cmd.Parameters.AddWithValue("@No", txNo.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("취소되었습니다.");
            cmd.Dispose();
            con.Close();
            this.Close();
        }
    }
}
