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

            // 휴가테이블 사용한 휴가, 상태값 변경
            String modifySql = "UPDATE Vaction SET status = @status WHERE id = @id";
            
            String selectSql = "SELECT Vaction.id, Vaction.userID, Vaction.date, Vaction.am, Vaction.pm, Vaction.reason, Vaction.status" +
               " FROM Vaction, totalVaction WHERE Vaction.id = totalVaction.id and Vaction.id = @id";

            String inputSql = "UPDATE totalVaction SET id=@id, userID=@userID, date=@date, am=@am, pm=@pm, reason=@reason, status=@status ";

            //String inputSql = "INSERT INTO totalVaction(id, userID, date, am, pm, reason, status) VALEUS  (@id, @userID, @date, @am, @pm, @reason, @status)";

            SqlConnection con = new SqlConnection(connString);
            con.Open();

            SqlCommand com = new SqlCommand();

            SqlCommand incmd = con.CreateCommand();
            SqlCommand modifycmd = con.CreateCommand();
            SqlCommand secmd = con.CreateCommand();

            com.Connection = con;

            modifycmd.CommandText = modifySql;
            secmd.CommandText = selectSql;
            incmd.CommandText = inputSql;

            secmd.Parameters.AddWithValue("@id", txNo.Text);
            SqlDataReader rs = secmd.ExecuteReader();

            modifycmd.Parameters.AddWithValue("@id", txNo.Text);
            modifycmd.Parameters.AddWithValue("@status", 1);

            rs.Read();
            
                
                var id = rs[0].ToString();
                var userID = rs[1].ToString();
                var date = rs[2].ToString();
                var am = rs[3].ToString();
                var pm = rs[4].ToString();
                var reason = rs[5].ToString();
                var status = rs[6].ToString();

            incmd.Parameters.AddWithValue("@id", id);
            incmd.Parameters.AddWithValue("@userID", userID);
            incmd.Parameters.AddWithValue("@date", date);
            incmd.Parameters.AddWithValue("@am", am);
            incmd.Parameters.AddWithValue("@pm", pm);
            incmd.Parameters.AddWithValue("@reason", reason);
            incmd.Parameters.AddWithValue("@status", status);



            rs.Close();

            modifycmd.ExecuteNonQuery();
            secmd.ExecuteNonQuery();
            incmd.ExecuteNonQuery();

            MessageBox.Show("등록이 완료되었습니다.");
            modifycmd.Dispose();
            secmd.Dispose();
            incmd.Dispose();
            con.Close();
            this.Close();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            String modifySql = "UPDATE Vaction SET status = @status WHERE id = @id";

            String selectSql = "SELECT Vaction.id, Vaction.userID, Vaction.date, Vaction.am, Vaction.pm, Vaction.reason, Vaction.status" +
               " FROM Vaction, totalVaction WHERE Vaction.id = totalVaction.id and Vaction.id = @id";

            String inputSql = "UPDATE totalVaction SET id=@id, userID=@userID, date=@date, am=@am, pm=@pm, reason=@reason, status=@status ";

            //String inputSql = "INSERT INTO totalVaction(id, userID, date, am, pm, reason, status) VALEUS  (@id, @userID, @date, @am, @pm, @reason, @status)";

            SqlConnection con = new SqlConnection(connString);
            con.Open();

            SqlCommand com = new SqlCommand();

            SqlCommand incmd = con.CreateCommand();
            SqlCommand modifycmd = con.CreateCommand();
            SqlCommand secmd = con.CreateCommand();

            com.Connection = con;

            modifycmd.CommandText = modifySql;
            secmd.CommandText = selectSql;
            incmd.CommandText = inputSql;

            secmd.Parameters.AddWithValue("@id", txNo.Text);
            SqlDataReader rs = secmd.ExecuteReader();

            modifycmd.Parameters.AddWithValue("@id", txNo.Text);
            modifycmd.Parameters.AddWithValue("@status", 2);

            rs.Read();


            var id = rs[0].ToString();
            var userID = rs[1].ToString();
            var date = rs[2].ToString();
            var am = rs[3].ToString();
            var pm = rs[4].ToString();
            var reason = rs[5].ToString();
            var status = rs[6].ToString();

            incmd.Parameters.AddWithValue("@id", id);
            incmd.Parameters.AddWithValue("@userID", userID);
            incmd.Parameters.AddWithValue("@date", date);
            incmd.Parameters.AddWithValue("@am", am);
            incmd.Parameters.AddWithValue("@pm", pm);
            incmd.Parameters.AddWithValue("@reason", reason);
            incmd.Parameters.AddWithValue("@status", status);



            rs.Close();

            modifycmd.ExecuteNonQuery();
            secmd.ExecuteNonQuery();
            incmd.ExecuteNonQuery();

            MessageBox.Show("등록이 완료되었습니다.");
            modifycmd.Dispose();
            secmd.Dispose();
            incmd.Dispose();
            con.Close();
            this.Close();
        }
    }
}
