using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VactionPage
{
    public partial class VacWaitList : Form
    {
        public VacWaitList()
        {
            InitializeComponent();
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

        private void VacWaitList_Load(object sender, EventArgs e)
        {
            //로그인한 데이터
            lbId.Text = Form1.LoginInfo.userId;
            // 관리자만 보이게끔 처리

            if (lbId.Text == "admin1")
            {
                lbVacOk.Show();
            }
            else
            {
                lbVacOk.Hide();
            }
        }
    }
}
