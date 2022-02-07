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
    }
}
