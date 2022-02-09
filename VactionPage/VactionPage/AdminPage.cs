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
    public partial class AdminPage : Form
    {
        String connString = "server=127.0.0.1; Initial Catalog=code;Integrated Security=SSPI";

        public AdminPage()
        {
            InitializeComponent();
        }

        private void lbAddVac_Click(object sender, EventArgs e)
        {
            VactionChoice vactionChoice = new VactionChoice();
            vactionChoice.Show();
        }

        private void lbVacList_Click(object sender, EventArgs e)
        {
            UserVactionList userVactionList = new UserVactionList();
            userVactionList.Show();
        }
        private void lbapp_Click(object sender, EventArgs e)
        {
            this.Hide();
            VacWaitList approvalList = new VacWaitList();
            approvalList.Show();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            //로그인한 데이터
            lbId.Text = Form1.LoginInfo.userId;
            // 관리자만 보이게끔 처리
            if (lbId.Text == "admin")
            {
                lbVacOk.Show();
            }
            else
            {
                lbVacOk.Hide();
            }
            SqlConnection con = new SqlConnection(connString);
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT vactionNo, id, reason, time, date, status FROM Vaction";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Vaction");

            vacListView.DataSource = ds;
            vacListView.DataMember = "Vaction";
            vacListView.Columns["vactionNo"].HeaderText = "번호";
            vacListView.Columns["id"].HeaderText = "아이디";
            vacListView.Columns["id"].Width = 110;
            vacListView.Columns["reason"].HeaderText = "휴가사유";
            vacListView.Columns["reason"].Width = 300;
            vacListView.Columns["time"].HeaderText = "휴가종류";
            vacListView.Columns["date"].HeaderText = "날짜";
            vacListView.Columns["date"].Width = 140;
            vacListView.Columns["status"].HeaderText = "상태";
        }

        private void goApproveForm_Click(object sender, EventArgs e)
        {
            VactionApproveForm vactionApproveForm = new VactionApproveForm();
            vactionApproveForm.ShowDialog();
        }
    }
}
