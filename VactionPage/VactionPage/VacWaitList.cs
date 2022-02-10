using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace VactionPage
{
    public partial class VacWaitList : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        
        public VacWaitList()
        {
            InitializeComponent();
            con = new SqlConnection("server=127.0.0.1; Initial Catalog=code;Integrated Security=SSPI");

        }
        private void VacWaitList_Load(object sender, EventArgs e)
        {
            //로그인한 데이터
            lbId.Text = Form1.LoginInfo.userId;
            con.Open();
            
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM userLogin";
            dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {

                //string userRole = dr["role"].ToString();
                if (lbId.Text == "admin")
                {
                    lbVacOk.Show();
                }
                else
                {
                    lbVacOk.Hide();
                }
            }
            con.Close();
            dr.Close();

            con.Open();
            cmd.CommandText = "SELECT id, userID, reason, am, pm, date, status FROM Vaction";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Vaction");
            vacListView.DataSource = ds;
            vacListView.DataMember = "Vaction";
            vacListView.Columns["id"].HeaderText = "번호";
            vacListView.Columns["userID"].HeaderText = "아이디";
            vacListView.Columns["userID"].Width = 120;
            vacListView.Columns["reason"].HeaderText = "휴가사유";
            vacListView.Columns["reason"].Width = 300;
            vacListView.Columns["am"].HeaderText = "오전휴가";
            vacListView.Columns["am"].Width = 40;
            vacListView.Columns["pm"].HeaderText = "오후휴가";
            vacListView.Columns["pm"].Width = 40;
            vacListView.Columns["date"].HeaderText = "날짜";
            vacListView.Columns["date"].Width = 120;
            vacListView.Columns["status"].HeaderText = "상태";
            vacListView.Columns["status"].Width = 70;
        }
        
        private void lbAddVac_Click(object sender, EventArgs e)
        {
            this.Hide();
            VactionChoice vactionChoice = new VactionChoice();
            vactionChoice.Show();
        }

        private void lbVacList_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserVactionList userVactionList = new UserVactionList();
            userVactionList.Show();
        }

        private void lbVacOk_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
        }
    }
}
