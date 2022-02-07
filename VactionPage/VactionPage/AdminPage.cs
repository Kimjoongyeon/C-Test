﻿using System;
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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }
        private string AdminPage_value;
        public string LoginData
        {
            get { return this.AdminPage_value; }
            set { this.AdminPage_value = value; }
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
            VacWaitList vacWaitList = new VacWaitList();
            vacWaitList.Show();
        }
    }
}
