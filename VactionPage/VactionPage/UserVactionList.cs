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
    public partial class UserVactionList : Form
    {
        public UserVactionList()
        {
            InitializeComponent();
        }
        private string UserVactionList_value;
        public string LoginData
        {
            get { return this.UserVactionList_value; }
            set { this.UserVactionList_value = value; }
        }
        private void UserVactionList_Load(object sender, EventArgs e)
        {
            lbName.Text = LoginData;
            // 관리자만 보이게끔 처리
            if (LoginData == "admin1")
            {
                lbVacOk.Show();
            }
            else
            {
                lbVacOk.Hide();
            }
            //displaDays();
        }

        private void lbAddVac_Click(object sender, EventArgs e)
        {
            this.Hide();
            VactionChoice vactionChoice = new VactionChoice();
            vactionChoice.Show();
        }

        private void lbapp_Click(object sender, EventArgs e)
        {
            this.Hide();
            VacWaitList approvalList = new VacWaitList();
            approvalList.Show();
        }

        private void lbVacOk_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
        }

        
    }
}
